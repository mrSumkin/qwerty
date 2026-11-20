using System;

// Token: 0x02000677 RID: 1655
public static class bp5
{
	// Token: 0x06002A14 RID: 10772 RVA: 0x000EDEAC File Offset: 0x000EC0AC
	public static string j(string A_0)
	{
		return string.Format("affection_{0}", A_0);
	}

	// Token: 0x06002A15 RID: 10773 RVA: 0x000EDEBC File Offset: 0x000EC0BC
	public static string i(string A_0)
	{
		return string.Format("PersonalMerchantReactionModifier_{0}", A_0);
	}

	// Token: 0x06002A16 RID: 10774 RVA: 0x000EDECC File Offset: 0x000EC0CC
	public static string h(string A_0)
	{
		return string.Format("quest_{0}_{1}", A_0, "state");
	}

	// Token: 0x06002A17 RID: 10775 RVA: 0x000EDEE0 File Offset: 0x000EC0E0
	public static string c(string A_0, string A_1)
	{
		return string.Format("quest_{0}_{1}", A_0, A_1);
	}

	// Token: 0x06002A18 RID: 10776 RVA: 0x000EDEF0 File Offset: 0x000EC0F0
	public static string g(string A_0)
	{
		return "powSrc_" + A_0;
	}

	// Token: 0x06002A19 RID: 10777 RVA: 0x000EDF00 File Offset: 0x000EC100
	public static string f(string A_0)
	{
		return "powSrc_" + A_0 + "_Ef";
	}

	// Token: 0x06002A1A RID: 10778 RVA: 0x000EDF14 File Offset: 0x000EC114
	public static string e(string A_0)
	{
		return A_0 + "_DisplayName";
	}

	// Token: 0x06002A1B RID: 10779 RVA: 0x000EDF24 File Offset: 0x000EC124
	public static string d(string A_0)
	{
		return "security_access:" + A_0;
	}

	// Token: 0x06002A1C RID: 10780 RVA: 0x000EDF34 File Offset: 0x000EC134
	public static string a(string A_0, int A_1)
	{
		return A_0 + "_hack_" + A_1.ToString();
	}

	// Token: 0x06002A1D RID: 10781 RVA: 0x000EDF48 File Offset: 0x000EC148
	public static string c(string A_0)
	{
		return A_0 + "_DisplayName";
	}

	// Token: 0x06002A1E RID: 10782 RVA: 0x000EDF58 File Offset: 0x000EC158
	public static string b(string A_0, string A_1)
	{
		return string.Format("powst_{0}_slot_{1}", A_0, A_1);
	}

	// Token: 0x06002A1F RID: 10783 RVA: 0x000EDF68 File Offset: 0x000EC168
	public static string a(string A_0, string A_1)
	{
		return string.Format("powst_{0}_slotLocked_{1}", A_0, A_1);
	}

	// Token: 0x06002A20 RID: 10784 RVA: 0x000EDF78 File Offset: 0x000EC178
	public static string b(string A_0)
	{
		return string.Format("npc_{0}_died", A_0);
	}

	// Token: 0x06002A21 RID: 10785 RVA: 0x000EDF88 File Offset: 0x000EC188
	public static bool a(string A_0)
	{
		return !string.IsNullOrEmpty(A_0) && A_0.StartsWith("g_");
	}

	// Token: 0x040016E8 RID: 5864
	private const string a = "npc_{0}_met";

	// Token: 0x040016E9 RID: 5865
	private const string b = "quest_{0}_{1}";

	// Token: 0x040016EA RID: 5866
	public static readonly string c = "facade";

	// Token: 0x040016EB RID: 5867
	public static readonly string d = "affection";

	// Token: 0x040016EC RID: 5868
	public static readonly string e = "fame";

	// Token: 0x040016ED RID: 5869
	public static readonly string f = "saCredits";

	// Token: 0x040016EE RID: 5870
	public static readonly string g = "powSrc_";

	// Token: 0x040016EF RID: 5871
	public static readonly string h = "player";

	// Token: 0x040016F0 RID: 5872
	public static readonly string i = "sys_game";

	// Token: 0x040016F1 RID: 5873
	public static readonly string j = "bulkDiscovery_";

	// Token: 0x040016F2 RID: 5874
	public static readonly string k = "TransportPart_";

	// Token: 0x040016F3 RID: 5875
	public static readonly string l = "GiantSkerderRuneNumber";

	// Token: 0x040016F4 RID: 5876
	public static readonly string m = "GiantSkerderHitBodyPart";

	// Token: 0x040016F5 RID: 5877
	public static readonly string n = "GiantSkerderHitBodyPart_DisplayName";

	// Token: 0x040016F6 RID: 5878
	public static readonly string o = "GiantSkerderHitBodyPartIsVital";
}
