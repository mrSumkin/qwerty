using System;
using System.Collections.ObjectModel;

// Token: 0x02000142 RID: 322
public class ej9
{
	// Token: 0x060007E9 RID: 2025 RVA: 0x00021F60 File Offset: 0x00020160
	public epf c()
	{
		return this.a;
	}

	// Token: 0x060007EA RID: 2026 RVA: 0x00021F68 File Offset: 0x00020168
	public void a(epf A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060007EB RID: 2027 RVA: 0x00021F74 File Offset: 0x00020174
	public ad7 e()
	{
		return this.b;
	}

	// Token: 0x060007EC RID: 2028 RVA: 0x00021F7C File Offset: 0x0002017C
	public void a(ad7 A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060007ED RID: 2029 RVA: 0x00021F88 File Offset: 0x00020188
	public string b()
	{
		return this.b.a(this.a.at9(), this.c().at5(), this.c().at6());
	}

	// Token: 0x060007EE RID: 2030 RVA: 0x00021FC4 File Offset: 0x000201C4
	public string f()
	{
		return this.c;
	}

	// Token: 0x060007EF RID: 2031 RVA: 0x00021FCC File Offset: 0x000201CC
	public string g()
	{
		return this.d;
	}

	// Token: 0x060007F0 RID: 2032 RVA: 0x00021FD4 File Offset: 0x000201D4
	public ReadOnlyCollection<aof> d()
	{
		return this.e;
	}

	// Token: 0x060007F1 RID: 2033 RVA: 0x00021FE0 File Offset: 0x000201E0
	public ej9(ad7 A_0, epf A_1)
	{
		czh.a(A_0, "stateQuestion");
		czh.a(A_1, "session");
		this.a = A_1;
		this.b = A_0;
		this.c = ((A_0.Questioner != null) ? A_0.Questioner.Name : "");
		this.d = ((A_0.Answerer != null) ? A_0.Answerer.Name : "");
		this.a();
	}

	// Token: 0x060007F2 RID: 2034 RVA: 0x0002206C File Offset: 0x0002026C
	private void a()
	{
		Collection<atr> collection = this.b.a(this.c().at5(), this.c().at6());
		Collection<aof> collection2 = new Collection<aof>();
		foreach (atr a_ in collection)
		{
			aof item = new aof(a_, this.a.at9(), this.a.at5(), this.a.at6());
			collection2.Add(item);
		}
		this.e = new ReadOnlyCollection<aof>(collection2);
	}

	// Token: 0x04000587 RID: 1415
	private epf a;

	// Token: 0x04000588 RID: 1416
	private ad7 b;

	// Token: 0x04000589 RID: 1417
	private string c;

	// Token: 0x0400058A RID: 1418
	private string d;

	// Token: 0x0400058B RID: 1419
	private ReadOnlyCollection<aof> e;
}
