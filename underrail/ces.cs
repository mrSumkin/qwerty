using System;

// Token: 0x0200066E RID: 1646
public sealed class ces
{
	// Token: 0x060029DD RID: 10717 RVA: 0x000ED880 File Offset: 0x000EBA80
	public static au2 c()
	{
		cnk cnk = ces.a();
		if (cnk.aqu() != null)
		{
			return cnk.aqu().v();
		}
		return null;
	}

	// Token: 0x060029DE RID: 10718 RVA: 0x000ED8AC File Offset: 0x000EBAAC
	public static cnk b()
	{
		if (ces.a == null)
		{
			ces.a = bpo.GetServiceOrThrow<cnk>();
		}
		return ces.a;
	}

	// Token: 0x060029DF RID: 10719 RVA: 0x000ED8C8 File Offset: 0x000EBAC8
	public static cnk a()
	{
		if (ces.a == null)
		{
			ces.a = bpo.GetService<cnk>();
		}
		return ces.a;
	}

	// Token: 0x040016CB RID: 5835
	private static cnk a;
}
