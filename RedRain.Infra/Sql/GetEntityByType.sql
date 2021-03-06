USE [RedRainDB]
GO
/****** Object:  StoredProcedure [dbo].[GetEntityByType]    Script Date: 11/07/2022 2:58:09 pm ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[GetEntityByType]
(
	@Type nvarchar(150)
)

as

begin try
  begin
     select * from Entities e where e.Type=@Type
  end
end try
begin catch
  declare @msg nvarchar(max) = error_message()
  raiserror(@msg, 11, 1)
end catch
GO


