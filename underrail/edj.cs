using System;
using TimelapseVertigo.Rules.Characters;

// Token: 0x0200065E RID: 1630
public sealed class edj : aun
{
	// Token: 0x06002961 RID: 10593 RVA: 0x000EBD6C File Offset: 0x000E9F6C
	public Gender a()
	{
		return this.a;
	}

	// Token: 0x06002962 RID: 10594 RVA: 0x000EBD74 File Offset: 0x000E9F74
	public string b()
	{
		return this.a.ToString();
	}

	// Token: 0x06002963 RID: 10595 RVA: 0x000EBD88 File Offset: 0x000E9F88
	public edj(Gender A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002964 RID: 10596 RVA: 0x000EBD98 File Offset: 0x000E9F98
	public string ar6(string A_0, string A_1)
	{
		if (this.a != Gender.Male)
		{
			return A_1;
		}
		return A_0;
	}

	// Token: 0x04001697 RID: 5783
	private Gender a;
}
