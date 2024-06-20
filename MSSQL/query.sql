------------------------SITE CHỦ---------------------------
GRANT EXECUTE ON OBJECT::[dbo].[SP_LayThongTinDangNhap_SV] TO SV; -- CAN XEM CAI NAY==============================================================
CREATE VIEW [dbo].[V_DS_PHANMANH]
AS
SELECT  TENCN=PUBS.description, TENSERVER= subscriber_server
   FROM dbo.sysmergepublications PUBS,  dbo.sysmergesubscriptions SUBS
   WHERE PUBS.pubid= SUBS.PUBID  AND PUBS.publisher <> SUBS.subscriber_server
GO
SELECT * FROM V_DS_PHANMANH

------------------------SITE 1,2,3 -------------------------
CREATE PROC [dbo].[SP_LayThongTinDangNhap]
@TENLOGIN NVARCHAR (50)
AS
BEGIN
DECLARE @TENUSER NVARCHAR(50), @UID INT
SELECT @UID= UID, @TENUSER=name FROM sys.sysusers  WHERE sid = SUSER_SID(@TENLOGIN)
SELECT USERNAME = @TENUSER, 
	HOTEN = (SELECT HO+ ' '+ TEN FROM GIANGVIEN  WHERE MAGV = @TENUSER ),
	TENNHOM= NAME
	FROM sys.sysusers 
	WHERE UID = (SELECT GROUPUID FROM SYS.SYSMEMBERS 
                   WHERE MEMBERUID= @UID)
END
GO
--Test
EXEC SP_LayThongTinTaiKhoan 'PGV1'
GO
------------------------SITE 1,2 -------------------------
CREATE PROC [dbo].[SP_LayThongTinDangNhap_SV]
@TENLOGIN NVARCHAR(50),
@MASV NCHAR(10),
@PASSWORD NVARCHAR(40)
AS 
BEGIN
	DECLARE @HOTEN NVARCHAR(60) 
	SELECT @HOTEN = HO+ ' '+ TEN FROM SINHVIEN WHERE MASV=@MASV AND PASSWORD=@PASSWORD
	IF @HOTEN IS NOT NULL
		BEGIN
			DECLARE @TENUSER NVARCHAR(50), @UID INT
			SELECT @UID= uid, @TENUSER= name FROM sys.sysusers WHERE sid= SUSER_SID(@TENLOGIN)
			SELECT MASV= @MASV,
					HOTEN =@HOTEN,
					TENNHOM= NAME
					FROM sys.sysusers 
					WHERE UID = (SELECT GROUPUID FROM SYS.SYSMEMBERS WHERE MEMBERUID= @UID)
		END
END
GO
--Test--
EXEC SP_LayThongTinDangNhap_SV 'SV1','N15DCCN001','123456' 
GO
-----------------------SITE 1 -----------------------

-----------------------SITE 2 -----------------------
-----------------------SITE 1,2,3 -----------------------
CREATE PROC [dbo].[SP_TaoLogin]
  @LGNAME VARCHAR(50),
  @PASS VARCHAR(50),
  @USERNAME VARCHAR(50),
  @ROLE VARCHAR(50)
AS
  DECLARE @RET INT
  EXEC @RET= SP_ADDLOGIN @LGNAME, @PASS,'QLDSV_TC'
  IF (@RET = 1)  -- LOGIN NAME BI TRUNG
	BEGIN
		RETURN 1
	END
	
  EXEC @RET= SP_GRANTDBACCESS @LGNAME, @USERNAME
  IF (@RET = 1)  -- USER  NAME BI TRUNG
	BEGIN
       EXEC SP_DROPLOGIN @LGNAME
       RETURN 2
	END
  EXEC sp_addrolemember @ROLE, @USERNAME
  IF @ROLE='PKT' OR @ROLE= 'PGV' OR @ROLE='KHOA'
    BEGIN 
		EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
		EXEC sp_addsrvrolemember @LGNAME, 'ProcessAdmin'
	END
RETURN 0  -- THANH CONG
GO 
-----------------------SITE 1,2,3 -----------------------
CREATE PROC [dbo].[SP_XoaLogin]
  @LGNAME VARCHAR(50),
  @USRNAME VARCHAR(50)
AS
  EXEC SP_DROPUSER @USRNAME
  EXEC SP_DROPLOGIN @LGNAME
GO
