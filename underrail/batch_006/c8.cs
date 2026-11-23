using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;

// Token: 0x0200022D RID: 557
public sealed class c8 : d6j, bxz, z6
{
	// Token: 0x06000F78 RID: 3960 RVA: 0x000407BC File Offset: 0x0003E9BC
	public ReadOnlyCollection<e3h> du()
	{
		return new List<e3h>(this.c.Values).AsReadOnly();
	}

	// Token: 0x06000F79 RID: 3961 RVA: 0x000407D4 File Offset: 0x0003E9D4
	public Guid qe()
	{
		return c8.a;
	}

	// Token: 0x06000F7A RID: 3962 RVA: 0x000407DC File Offset: 0x0003E9DC
	public string y8()
	{
		return "PlayfieldManager";
	}

	// Token: 0x06000F7B RID: 3963 RVA: 0x000407E4 File Offset: 0x0003E9E4
	public b2e dv()
	{
		return this.e;
	}

	// Token: 0x06000F7C RID: 3964 RVA: 0x000407EC File Offset: 0x0003E9EC
	public bool dw()
	{
		return this.f;
	}

	// Token: 0x06000F7D RID: 3965 RVA: 0x000407F4 File Offset: 0x0003E9F4
	public c8() : this(false, true)
	{
	}

	// Token: 0x06000F7E RID: 3966 RVA: 0x00040800 File Offset: 0x0003EA00
	public c8(bool A_0, bool A_1)
	{
		this.f = A_0;
		if (A_1)
		{
			this.e = new b2e();
		}
	}

	// Token: 0x06000F7F RID: 3967 RVA: 0x00040838 File Offset: 0x0003EA38
	public e3h dx(string A_0)
	{
		czh.a(A_0, "name");
		return this.c.SafeGet(A_0, this.d);
	}

	// Token: 0x06000F80 RID: 3968 RVA: 0x00040858 File Offset: 0x0003EA58
	public e3h dy()
	{
		return Enumerable.FirstOrDefault<e3h>(this.c.Values);
	}

	// Token: 0x06000F81 RID: 3969 RVA: 0x0004086C File Offset: 0x0003EA6C
	public void dz(e3h A_0)
	{
		czh.a(A_0, "playfield");
		this.c.a(A_0.Name, A_0, this.d);
	}

	// Token: 0x06000F82 RID: 3970 RVA: 0x00040894 File Offset: 0x0003EA94
	public e3h d0(string A_0)
	{
		czh.a(A_0, "name");
		return this.c.SafeRemove(A_0, this.d);
	}

	// Token: 0x06000F83 RID: 3971 RVA: 0x000408B4 File Offset: 0x0003EAB4
	public void a()
	{
		this.e.d();
	}

	// Token: 0x06000F84 RID: 3972 RVA: 0x000408C4 File Offset: 0x0003EAC4
	public void d1(e6d A_0)
	{
		foreach (e3h e3h in this.c.Values)
		{
			e3h.d1(A_0);
		}
	}

	// Token: 0x04000930 RID: 2352
	private static readonly Guid a = new Guid("{EA2AE4E1-5CF8-494c-B151-DD0C6BFA2562}");

	// Token: 0x04000931 RID: 2353
	private const string b = "PlayfieldManager";

	// Token: 0x04000932 RID: 2354
	private Dictionary<string, e3h> c = new Dictionary<string, e3h>();

	// Token: 0x04000933 RID: 2355
	private ReaderWriterLock d = new ReaderWriterLock();

	// Token: 0x04000934 RID: 2356
	private b2e e;

	// Token: 0x04000935 RID: 2357
	private bool f;
}
