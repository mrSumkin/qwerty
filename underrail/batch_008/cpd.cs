using System;

// Token: 0x020005B7 RID: 1463
public sealed class cpd : ae1
{
	// Token: 0x06002708 RID: 9992 RVA: 0x000E3524 File Offset: 0x000E1724
	public override string gr()
	{
		return "float";
	}

	// Token: 0x06002709 RID: 9993 RVA: 0x000E3530 File Offset: 0x000E1730
	public override object gs(string A_0)
	{
		float num;
		float.TryParse(A_0, out num);
		return num;
	}
}
