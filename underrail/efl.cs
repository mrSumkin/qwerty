using System;
using System.Runtime.InteropServices;
using Ouroboros.Core.Logging;

// Token: 0x020002A2 RID: 674
public class efl : akt
{
	// Token: 0x0600139E RID: 5022 RVA: 0x00051AC4 File Offset: 0x0004FCC4
	public bool asq()
	{
		return this.a;
	}

	// Token: 0x0600139F RID: 5023
	[DllImport("SteamHelper.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern bool SteamHelper_InitSteam();

	// Token: 0x060013A0 RID: 5024
	[DllImport("SteamHelper.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void SteamHelper_ShutdownSteam();

	// Token: 0x060013A1 RID: 5025
	[DllImport("SteamHelper.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern bool SteamHelper_SetAchievement(string A_0);

	// Token: 0x060013A2 RID: 5026
	[DllImport("SteamHelper.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern bool SteamHelper_ClearAchievement(string A_0);

	// Token: 0x060013A3 RID: 5027
	[DllImport("SteamHelper.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int SteamHelper_IncrementStat(string A_0);

	// Token: 0x060013A4 RID: 5028
	[DllImport("SteamHelper.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern bool SteamHelper_ResetAllStats(bool A_0);

	// Token: 0x060013A5 RID: 5029
	[DllImport("SteamHelper.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern bool SteamHelper_IsOnSteamDeck();

	// Token: 0x060013A6 RID: 5030
	[DllImport("SteamHelper.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern bool SteamHelper_IsRunningOnWine();

	// Token: 0x060013A7 RID: 5031
	[DllImport("SteamHelper.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern bool SteamHelper_ShowKeyboard(int A_0, int A_1, int A_2, int A_3);

	// Token: 0x060013A8 RID: 5032 RVA: 0x00051AD0 File Offset: 0x0004FCD0
	public bool asr()
	{
		try
		{
			this.a = efl.SteamHelper_InitSteam();
		}
		catch (Exception ex)
		{
			cvq cvq = dr3.e();
			if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Error, 119))
			{
				cvq.n7(LogSeverity.Error, 119, "[Steam Manager] Error occurred while initializing SteamHelper. Exception: " + ex.ToString());
			}
		}
		this.b = DateTime.Now;
		return this.a;
	}

	// Token: 0x060013A9 RID: 5033 RVA: 0x00051B54 File Offset: 0x0004FD54
	public void ass()
	{
		if (!this.a && DateTime.Now > this.b + TimeSpan.FromMinutes(5.0))
		{
			this.asr();
		}
	}

	// Token: 0x060013AA RID: 5034 RVA: 0x00051B90 File Offset: 0x0004FD90
	public void ast()
	{
		if (this.a)
		{
			try
			{
				efl.SteamHelper_ShutdownSteam();
			}
			catch (Exception ex)
			{
				cvq cvq = dr3.e();
				if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Error, 119))
				{
					cvq.n7(LogSeverity.Error, 119, "[Steam Manager] Error occurred while shuting down SteamHelper. Exception: " + ex.ToString());
				}
			}
		}
	}

	// Token: 0x060013AB RID: 5035 RVA: 0x00051C08 File Offset: 0x0004FE08
	public bool asu(bool A_0)
	{
		return this.a && efl.SteamHelper_ResetAllStats(A_0);
	}

	// Token: 0x060013AC RID: 5036 RVA: 0x00051C20 File Offset: 0x0004FE20
	public bool asv(string A_0)
	{
		cz7 service = bpo.GetService<cz7>();
		if (service != null)
		{
			service.ae2(A_0);
		}
		return this.a && efl.SteamHelper_SetAchievement(A_0);
	}

	// Token: 0x060013AD RID: 5037 RVA: 0x00051C54 File Offset: 0x0004FE54
	public bool asw(string A_0)
	{
		return this.a && efl.SteamHelper_ClearAchievement(A_0);
	}

	// Token: 0x060013AE RID: 5038 RVA: 0x00051C6C File Offset: 0x0004FE6C
	public bool asx(string A_0)
	{
		cz7 service = bpo.GetService<cz7>();
		if (service != null)
		{
			service.ae3(A_0);
		}
		if (this.a)
		{
			efl.SteamHelper_IncrementStat(A_0);
			return true;
		}
		return false;
	}

	// Token: 0x060013AF RID: 5039 RVA: 0x00051CA4 File Offset: 0x0004FEA4
	public bool asy()
	{
		return this.a && efl.SteamHelper_IsOnSteamDeck();
	}

	// Token: 0x060013B0 RID: 5040 RVA: 0x00051CB8 File Offset: 0x0004FEB8
	public bool asz()
	{
		return efl.SteamHelper_IsRunningOnWine();
	}

	// Token: 0x060013B1 RID: 5041 RVA: 0x00051CC0 File Offset: 0x0004FEC0
	public bool as0(int A_0, int A_1, int A_2, int A_3)
	{
		return this.a && efl.SteamHelper_ShowKeyboard(A_0, A_1, A_2, A_3);
	}

	// Token: 0x04000AA7 RID: 2727
	private bool a;

	// Token: 0x04000AA8 RID: 2728
	private DateTime b;
}
