using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x02000218 RID: 536
internal class e6u : ICloneable, IComparable<e6u>
{
	// Token: 0x06000EFF RID: 3839 RVA: 0x0003EB80 File Offset: 0x0003CD80
	public abo a()
	{
		return this.d[0];
	}

	// Token: 0x06000F00 RID: 3840 RVA: 0x0003EB90 File Offset: 0x0003CD90
	public e6u(er0 A_0)
	{
		czh.a(A_0, "session");
		this.a = A_0;
		this.c = A_0.aup();
	}

	// Token: 0x06000F01 RID: 3841 RVA: 0x0003EBC4 File Offset: 0x0003CDC4
	public int a(ee4 A_0)
	{
		int result = -1;
		if (this.d.Count > 0 && this.d[0].c.b == A_0.b)
		{
			result = this.a.p().p4(A_0.a, this.a().c.a) + this.e;
		}
		return result;
	}

	// Token: 0x06000F02 RID: 3842 RVA: 0x0003EC34 File Offset: 0x0003CE34
	public void a(abo A_0)
	{
		if (this.b != null && A_0.c.b != this.b.Value.c.b)
		{
			return;
		}
		if (this.b != null)
		{
			this.e += this.a.p().p4(this.b.Value.c.a, A_0.c.a);
		}
		this.e += A_0.d;
		this.b = new abo?(A_0.a());
		this.d.Add(A_0);
	}

	// Token: 0x06000F03 RID: 3843 RVA: 0x0003ECF8 File Offset: 0x0003CEF8
	public bool b(abo A_0)
	{
		e6u.a a = new e6u.a();
		a.a = A_0;
		return (this.b == null || a.a.c.b == this.b.Value.c.b) && !Enumerable.Any<abo>(this.d, new Func<abo, bool>(a.a));
	}

	// Token: 0x06000F04 RID: 3844 RVA: 0x0003ED68 File Offset: 0x0003CF68
	public bool c()
	{
		if (this.b == null)
		{
			return false;
		}
		if ((this.a.q() & czr.b) != czr.b && this.b.Value.c.b != this.c.b)
		{
			return false;
		}
		this.e += this.a.p().p4(this.b.Value.c.a, this.c.a);
		return true;
	}

	// Token: 0x06000F05 RID: 3845 RVA: 0x0003EE00 File Offset: 0x0003D000
	public object Clone()
	{
		return this.b();
	}

	// Token: 0x06000F06 RID: 3846 RVA: 0x0003EE08 File Offset: 0x0003D008
	public e6u b()
	{
		e6u e6u = new e6u(this.a);
		e6u.d.AddRange(this.d);
		e6u.e = this.e;
		e6u.b = this.b;
		return e6u;
	}

	// Token: 0x06000F07 RID: 3847 RVA: 0x0003EE44 File Offset: 0x0003D044
	public override string ToString()
	{
		string text = "";
		if (this.d.Count > 0)
		{
			using (List<abo>.Enumerator enumerator = this.d.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					abo abo = enumerator.Current;
					string str = text;
					string format = "{0} - ";
					ee4 ee = abo.c;
					text = str + string.Format(format, ee.ToString());
				}
				goto IL_77;
			}
		}
		text = "Unknown - ";
		IL_77:
		return string.Format("{0}{1}. G: {2}", text, this.c, this.e);
	}

	// Token: 0x06000F08 RID: 3848 RVA: 0x0003EEFC File Offset: 0x0003D0FC
	public int CompareTo(e6u other)
	{
		if (this.a().e == chj.b)
		{
			return -1;
		}
		return 1;
	}

	// Token: 0x040008FD RID: 2301
	private er0 a;

	// Token: 0x040008FE RID: 2302
	private abo? b;

	// Token: 0x040008FF RID: 2303
	private ee4 c;

	// Token: 0x04000900 RID: 2304
	public List<abo> d = new List<abo>();

	// Token: 0x04000901 RID: 2305
	public int e;

	// Token: 0x02000219 RID: 537
	[CompilerGenerated]
	private sealed class a
	{
		// Token: 0x06000F0A RID: 3850 RVA: 0x0003EF1C File Offset: 0x0003D11C
		internal bool a(abo A_0)
		{
			return A_0.a == this.a.a;
		}

		// Token: 0x04000902 RID: 2306
		public abo a;
	}
}
