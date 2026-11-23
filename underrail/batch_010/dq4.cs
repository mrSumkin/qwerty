using System;

// Token: 0x020005C5 RID: 1477
public sealed class dq4 : ae1
{
	// Token: 0x0600273D RID: 10045 RVA: 0x000E41F8 File Offset: 0x000E23F8
	public override string gr()
	{
		return "int32";
	}

	// Token: 0x0600273E RID: 10046 RVA: 0x000E4200 File Offset: 0x000E2400
	public override object gs(string A_0)
	{
		int num;
		int.TryParse(A_0, out num);
		return num;
	}
}
