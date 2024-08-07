﻿USE [QLDSV_TC]
GO
-----------------------------------------------------
ALTER  PROCEDURE [dbo].[sp_InBangDiemTongKet]
	-- khai bao cac bien tam 
	@MALOP nchar(10)
AS
BEGIN
	SELECT HOTEN = SV.MASV + ' - ' +SV.HO + ' ' + SV.TEN, DIEM.TENMH, DIEMTK=ISNULL(DIEM.DIEM,0)
FROM SINHVIEN AS SV
INNER JOIN (SELECT MASV, DIEM = MAX(DIEM), TENMH
			FROM 
			(SELECT DK.MALTC, DK.MASV, DIEM = DK.DIEM_CC *0.1 + DK.DIEM_CK * 0.6 + DK.DIEM_GK * 0.3 
			FROM DANGKY DK
			GROUP BY DK.MALTC, DK.MASV, DK.DIEM_CC, DK.DIEM_CK, DK.DIEM_GK) AS DIEM

			LEFT JOIN  (
				SELECT LTC.MALTC, MH.TENMH
				FROM MONHOC MH
				INNER JOIN LOPTINCHI LTC
				ON LTC.MAMH = MH.MAMH
			) AS MH

			ON DIEM.MALTC = MH.MALTC
			GROUP BY MH.TENMH, DIEM.MASV) AS DIEM

ON SV.MASV = DIEM.MASV  AND SV.MALOP = @MALOP
GROUP BY sv.HO, sv.MASV, sv.TEN, DIEM.TENMH, DIEM.DIEM
ORDER BY sv.TEN, sv.HO ASC
END
GO
EXEC sp_InBangDiemTongKet 'D15CQIS01'
GO
------------------------------------------------------------------------------------------------------------
ALTER PROCEDURE [dbo].[sp_PhieuDiem]
	-- khai bao cac bien 
	@MASV char(12)
AS
BEGIN
   SELECT  ROW_NUMBER() over(ORDER BY mh.TENMH) STT, mh.TENMH , COALESCE(MAX(dk.DIEM_CC *0.1 + dk.DIEM_CK * 0.6 + dk.DIEM_GK * 0.3), 0) AS 'DIEM'
   
   FROM (SELECT * from DANGKY as dk where dk.MASV = @MASV ) as dk
	
   INNER JOIN LOPTINCHI as ltc ON dk.MALTC= ltc.MALTC
   INNER JOIN MONHOC as mh ON mh.MAMH = ltc.MAMH
   

   GROUP BY mh.TENMH
   ORDER BY mh.TENMH
END

GO
---------------------------------------------------------------------------------------------------------------


GRANT EXECUTE ON OBJECT::dbo.sp_LayDSLopTinChiDeDangKy TO SV;
GRANT EXECUTE ON OBJECT::dbo.sp_LayDSLopTinChiDaDangKy TO SV;
GRANT EXECUTE ON OBJECT::dbo.sp_InBangDiemTongKet TO SV;
GRANT EXECUTE ON OBJECT::dbo.sp_PhieuDiem TO SV;
GRANT EXECUTE ON OBJECT::dbo.sp_DangKyLopTinChi TO SV;
GO

/*
ALTER PROCEDURE [dbo].[sp_LayDSLopTinChiDeDangKy]
	-- khai bao cac bien tam 
@Nienkhoa nchar(9),
@Hocky int,
@MaSV nchar(10)
as
BEGIN
SELECT	LTC.MALTC, 
		LTC.MAMH,MH.TENMH, 
		GV.HO + ' '+GV.TEN AS HOTENGV, 
		LTC.NHOM, LTC.SOSVTOITHIEU, 
		ISNULL(DK.SOLUONGDK,0) AS SOLUONGDADK
FROM (SELECT  LOPTINCHI.MALTC,MAMH,NHOM,MAGV,SOSVTOITHIEU
	FROM LOPTINCHI 
	LEFT JOIN (SELECT MALTC FROM DANGKY WHERE MASV=@MaSV AND (HUYDANGKY =0 or HUYDANGKY is null) GROUP BY MALTC) AS DK
	ON LOPTINCHI.MALTC=DK.MALTC
	WHERE DK.MALTC IS NULL  AND NIENKHOA=@Nienkhoa AND HOCKY=@Hocky AND (HUYLOP =0 OR HUYLOP IS NULL)) AS LTC	
LEFT JOIN (SELECT MALTC, COUNT(*) AS SOLUONGDK FROM DANGKY WHERE (HUYDANGKY =0 or HUYDANGKY is null) GROUP BY MALTC )AS DK
ON DK.MALTC=LTC.MALTC
JOIN (SELECT MAMH,TENMH FROM MONHOC) MH 
ON MH.MAMH =LTC.MAMH
JOIN (SELECT MAGV,HO,TEN FROM GIANGVIEN) GV 
ON GV.MAGV=LTC.MAGV
END
go
*/
--TEST--
EXEC dbo.sp_LayDSLopTinChiDeDangKy '2021-2022',2,'N15DCCN001'
EXEC sp_LayDSLopTinChiDeDangKy '2021-2022',2,'N15DCCN003'
go
-----------SP UDPATE--------------------------------------------------------------------------------------------------------
ALTER proc [dbo].[sp_LayDSLopTinChiDeDangKy]
@Nienkhoa nchar(9),
@Hocky int,
@MaSV nchar(10)
as
BEGIN
	
select  MALTC,MAMH,TENMH=(select TENMH from MONHOC a where a.MAMH=ltc.MAMH),
		NHOM=ltc.NHOM, GIANGVIEN=(SELECT gv.HO+' '+gv.TEN FROM GIANGVIEN gv WHERE gv.MAGV=ltc.MAGV),
		SOSVTOITHIEU,
         DADANGKY=(select COUNT(*) from DANGKY dk where dk.MALTC = ltc.MALTC and (dk.HUYDANGKY =0 or dk.HUYDANGKY is null))
  from LOPTINCHI ltc
 WHERE ltc.NIENKHOA = @Nienkhoa and ltc.HOCKY = @Hocky and (ltc.HUYLOP = 0 OR ltc.HUYLOP is null) and 
 @MaSV not in (select MASV from DANGKY where MALTC =ltc.MALTC and (HUYDANGKY =0 or HUYDANGKY is null))
END
GO
--TEST--
EXEC dbo.sp_LayDSLopTinChiDeDangKy '2021-2022',1,'N15DCCN008'
EXEC sp_LayDSLopTinChiDeDangKy '2021-2022',2,'N15DCCN003'
go
/*
ALTER PROCEDURE [dbo].[sp_LayDSLopTinChiDaDangKy]
	-- khai bao cac bien tam 
	@MASV nchar(10), @NIENKHOA nchar(9), @HOCKY int
AS
BEGIN

	SELECT LTC.MALTC, MH.MAMH, MH.TENMH, LTC.NHOM
	FROM  LOPTINCHI as LTC

	INNER JOIN MONHOC as MH ON MH.MAMH = LTC.MAMH
	INNER JOIN (SELECT MASV, MALTC FROM DANGKY WHERE MASV = @MASV AND HUYDANGKY = 0) as DK ON DK.MALTC = LTC.MALTC

	WHERE LTC.NIENKHOA = @NIENKHOA AND LTC.HOCKY = @HOCKY AND LTC.HUYLOP = 0 
	GROUP BY LTC.NHOM, MH.MAMH, MH.TENMH, LTC.MALTC
	ORDER BY MH.TENMH, LTC.NHOM  
END
GO
*/
--------------------------SP UPDATE-----------------------------------------------
ALTER proc [dbo].[sp_LayDSLopTinChiDaDangKy]
@Nienkhoa nchar(9),
@Hocky int,
@MaSV nchar(10)
as
BEGIN
	
select  MALTC,MAMH,TENMH=(select TENMH from MONHOC a where a.MAMH=ltc.MAMH),
		NHOM=ltc.NHOM, GIANGVIEN=(SELECT gv.HO+' '+gv.TEN FROM GIANGVIEN gv WHERE gv.MAGV=ltc.MAGV),
         DADANGKY=(select COUNT(*) from DANGKY dk where dk.MALTC = ltc.MALTC and (dk.HUYDANGKY =0 or dk.HUYDANGKY is null))
  from LOPTINCHI ltc
 WHERE ltc.NIENKHOA = @Nienkhoa and ltc.HOCKY = @Hocky and ltc.HUYLOP = 0 and 
 @MaSV in (select MASV from DANGKY where MALTC =ltc.MALTC and (HUYDANGKY =0 or HUYDANGKY is null))
END
GO
/*

ALTER proc sp_DangKyLopTinChi
@MALTC int,
@MASV nchar(10)
AS
BEGIN 
  IF EXISTS ( SELECT * FROM DANGKY WHERE MALTC=@MALTC AND MASV=@MASV AND HUYDANGKY=1)
    BEGIN 
		UPDATE DANGKY 
		SET HUYDANGKY=0
		WHERE MALTC=@MALTC AND MASV=@MASV
	END
  ELSE
	BEGIN
		INSERT INTO DANGKY(MALTC,MASV) VALUES (@MALTC,@MASV)
	END

END
GO
*/
--------------------------SP update -----------------------------------------------

ALTER PROCEDURE sp_DangKyLopTinChi
	@MALTC int, @MASV nchar(10), @MAMH nchar(10), @HOCKY int, @NIENKHOA nchar(9)
AS
BEGIN
	SELECT DK.MALTC 
	FROM DANGKY DK
	LEFT JOIN LOPTINCHI LTC
	ON  DK.MALTC = LTC.MALTC
	WHERE	LTC.MAMH = @MAMH AND 
			LTC.NIENKHOA = @NIENKHOA AND 
			LTC.HOCKY = @HOCKY  AND 
			DK.HUYDANGKY = 0 AND 
			DK.MASV = @MASV
	
	IF @@ROWCOUNT > 0
	BEGIN
		RAISERROR ('Môn học đã đăng ký rồi!', 16,1)
		RETURN 1;
	END
	UPDATE DANGKY 
	SET    HUYDANGKY = 0 
	WHERE  MALTC = @MALTC AND MASV = @MASV 

	IF @@ROWCOUNT = 0 
	  INSERT INTO DANGKY (MALTC, MASV, DIEM_CC, DIEM_GK, DIEM_CK, HUYDANGKY) 
	  VALUES (@MALTC, @MASV , 0, 0, 0, 0)
END
GO
exec sp_DangKyLopTinChi 2,'N15DCCN001', 'CTDL      ', 1, '2021-2022'
--------------------------------------------------------------------------

CREATE proc [dbo].[SP_HUY_DKY_LTC]
@MALTC int,
@MASV nchar(10)
AS
BEGIN 
  IF EXISTS ( SELECT * FROM DANGKY WHERE MALTC=@MALTC AND MASV=@MASV AND (HUYDANGKY=0 OR HUYDANGKY is null))
    BEGIN 
		UPDATE DANGKY 
		SET HUYDANGKY=1
		WHERE MALTC=@MALTC AND MASV=@MASV
	END
END
GO
--------------------------TEST------------------------------------------------
SELECT	LTC.MALTC, 
		LTC.MAMH,MH.TENMH, 
		GV.HO + ' '+GV.TEN AS HOTENGV, 
		LTC.NHOM, LTC.SOSVTOITHIEU, 
		ISNULL(DK.SOLUONGDK,0) AS SOLUONGDADK
FROM (SELECT  LOPTINCHI.MALTC,MAMH,NHOM,MAGV,SOSVTOITHIEU
	FROM LOPTINCHI 
	LEFT JOIN (SELECT MALTC FROM DANGKY WHERE MASV='N15DCCN003' AND (HUYDANGKY =0 or HUYDANGKY is null) GROUP BY MALTC) AS DK
	ON LOPTINCHI.MALTC=DK.MALTC
	WHERE DK.MALTC IS NULL  AND NIENKHOA='2021-2022' AND HOCKY=2 AND (HUYLOP =0 OR HUYLOP IS NULL)) AS LTC	
LEFT JOIN (SELECT MALTC, COUNT(*) AS SOLUONGDK FROM DANGKY WHERE (HUYDANGKY =0 or HUYDANGKY is null) GROUP BY MALTC )AS DK
ON DK.MALTC=LTC.MALTC
JOIN (SELECT MAMH,TENMH FROM MONHOC) MH 
ON MH.MAMH =LTC.MAMH
JOIN (SELECT MAGV,HO,TEN FROM GIANGVIEN) GV 
ON GV.MAGV=LTC.MAGV
GO
CREATE proc [dbo].[SP_HUY_DKY_LTC]
@MALTC int,
@MASV nchar(10)
AS
BEGIN 
  IF EXISTS ( SELECT * FROM DANGKY WHERE MALTC=@MALTC AND MASV=@MASV AND (HUYDANGKY=0 OR HUYDANGKY is null))
    BEGIN 
		UPDATE DANGKY 
		SET HUYDANGKY=1
		WHERE MALTC=@MALTC AND MASV=@MASV
	END
END

ALTER proc [dbo].[SP_HUY_DKY_LTC]
@MALTC int,
@MASV nchar(10)
AS
BEGIN 
  IF EXISTS ( 
    SELECT * 
    FROM DANGKY 
    WHERE MALTC=@MALTC 
      AND MASV=@MASV 
      AND (HUYDANGKY=0 OR HUYDANGKY IS NULL)
      AND DIEM_CC IS NULL 
      AND DIEM_GK IS NULL 
      AND DIEM_CK IS NULL
  )
  BEGIN 
    UPDATE DANGKY 
    SET HUYDANGKY=1
    WHERE MALTC=@MALTC AND MASV=@MASV
  END
  ELSE
	 RAISERROR ('Không thể hủy đăng ký vì đã có điểm môn học!', 16,1)
END
	