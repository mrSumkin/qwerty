using System;

// Token: 0x020005C1 RID: 1473
public sealed class c2v : ae1
{
	// Token: 0x0600272D RID: 10029 RVA: 0x000E3DCC File Offset: 0x000E1FCC
	public override string gr()
	{
		return "bool";
	}

	// Token: 0x0600272E RID: 10030 RVA: 0x000E3DD4 File Offset: 0x000E1FD4
	public override object gs(string A_0)
	{
		if (A_0 == null)
		{
			return false;
		}
		if (string.Equals(A_0, "y", StringComparison.OrdinalIgnoreCase) || string.Equals(A_0, "yes", StringComparison.OrdinalIgnoreCase) || string.Equals(A_0, "on", StringComparison.OrdinalIgnoreCase) || string.Equals(A_0, "1", StringComparison.OrdinalIgnoreCase))
		{
			return true;
		}
		bool flag;
		bool.TryParse(A_0, out flag);
		return flag;
	}
}
