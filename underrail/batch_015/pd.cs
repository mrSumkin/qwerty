using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x0200034C RID: 844
public abstract class pd : c96
{
	// Token: 0x060017DF RID: 6111 RVA: 0x00079188 File Offset: 0x00077388
	public List<c96> g()
	{
		return this.a;
	}

	// Token: 0x060017E0 RID: 6112 RVA: 0x00079190 File Offset: 0x00077390
	public void a(List<c96> A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060017E1 RID: 6113 RVA: 0x0007919C File Offset: 0x0007739C
	public c96 f()
	{
		return this.b;
	}

	// Token: 0x060017E2 RID: 6114 RVA: 0x000791A4 File Offset: 0x000773A4
	protected pd(string A_0) : base(A_0)
	{
	}

	// Token: 0x060017E3 RID: 6115 RVA: 0x000791B8 File Offset: 0x000773B8
	protected pd(string A_0, IEnumerable<c96> A_1) : base(A_0)
	{
		if (A_1 != null)
		{
			this.a(A_1);
		}
	}

	// Token: 0x060017E4 RID: 6116 RVA: 0x000791DC File Offset: 0x000773DC
	public void a(c96 A_0)
	{
		if (A_0 != null)
		{
			A_0.b(this);
			this.a.Add(A_0);
		}
	}

	// Token: 0x060017E5 RID: 6117 RVA: 0x000791F8 File Offset: 0x000773F8
	public void a(int A_0, c96 A_1)
	{
		if (A_1 != null)
		{
			A_1.b(this);
			this.a.Insert(A_0, A_1);
		}
	}

	// Token: 0x060017E6 RID: 6118 RVA: 0x00079218 File Offset: 0x00077418
	public void a(IEnumerable<c96> A_0)
	{
		foreach (c96 a_ in A_0)
		{
			this.a(a_);
		}
	}

	// Token: 0x060017E7 RID: 6119 RVA: 0x0007926C File Offset: 0x0007746C
	public void a(int A_0, IEnumerable<c96> A_1)
	{
		int num = A_0;
		foreach (c96 a_ in A_1)
		{
			this.a(num, a_);
			num++;
		}
	}

	// Token: 0x060017E8 RID: 6120 RVA: 0x000792C4 File Offset: 0x000774C4
	public override ej1 aci(TimeSpan A_0, double A_1)
	{
		if (this.b != null && this.b.aci(A_0, A_1) != ej1.a)
		{
			this.b = null;
			if (this.Subject != null)
			{
				this.Subject.t();
			}
		}
		return ej1.a;
	}

	// Token: 0x060017E9 RID: 6121 RVA: 0x00079304 File Offset: 0x00077504
	public void aa(TimeSpan A_0, double A_1)
	{
		c96 c = null;
		float num = float.MinValue;
		foreach (c96 c2 in this.a)
		{
			if (c2.acj(A_0, A_1))
			{
				float num2 = c2.km(this.b == c2);
				if (num2 > num)
				{
					c = c2;
					num = num2;
				}
			}
		}
		if (c != this.b)
		{
			if (this.b != null)
			{
				this.b.ack();
			}
			this.b = c;
			if (this.b != null)
			{
				this.b.mc(A_0, A_1);
			}
		}
		pd pd = this.b as pd;
		if (pd != null)
		{
			pd.aa(A_0, A_1);
		}
	}

	// Token: 0x060017EA RID: 6122 RVA: 0x000793E8 File Offset: 0x000775E8
	public override void ack()
	{
		if (this.f() != null)
		{
			this.f().ack();
		}
	}

	// Token: 0x060017EB RID: 6123 RVA: 0x00079400 File Offset: 0x00077600
	public List<string> ab()
	{
		List<string> list = new List<string>();
		if (this.b != null)
		{
			list.Add(this.b.Name);
			pd pd = this.b as pd;
			if (pd != null)
			{
				list.AddRange(pd.ab());
			}
		}
		return list;
	}

	// Token: 0x060017EC RID: 6124 RVA: 0x00079450 File Offset: 0x00077650
	public void ac(List<string> A_0)
	{
		if (A_0 != null && A_0.Count > 0)
		{
			pd.a a = new pd.a();
			a.a = A_0[0];
			A_0.RemoveAt(0);
			c96 c = Enumerable.FirstOrDefault<c96>(Enumerable.Where<c96>(this.a, new Func<c96, bool>(a.a)));
			if (c != null)
			{
				this.b = c;
				if (A_0.Count > 0)
				{
					pd pd = this.b as pd;
					if (pd != null)
					{
						pd.ac(A_0);
					}
				}
			}
		}
	}

	// Token: 0x04000E1A RID: 3610
	private List<c96> a = new List<c96>();

	// Token: 0x04000E1B RID: 3611
	private new c96 b;

	// Token: 0x0200034D RID: 845
	[CompilerGenerated]
	private sealed class a
	{
		// Token: 0x060017EE RID: 6126 RVA: 0x000794E0 File Offset: 0x000776E0
		internal bool a(c96 A_0)
		{
			return A_0.Name == this.a;
		}

		// Token: 0x04000E1C RID: 3612
		public string a;
	}
}
