using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;

// Token: 0x020012F7 RID: 4855
[eiz("POA")]
[Serializable]
public sealed class dt5 : Aspect<c5x>, bp1
{
	// Token: 0x06006BED RID: 27629 RVA: 0x002D5134 File Offset: 0x002D3334
	private dt5(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() >= 69)
		{
			this.a = (A_0.GetValue("POA:P", typeof(bool?)) as bool?);
		}
		else
		{
			this.a = new bool?(A_0.GetBoolean("POA:P"));
		}
		di7.ReadList<string>("POA:PS", ref this.b, A_0);
		if (ell.a() >= 37)
		{
			di7.ReadList<cze>("POA:PONJ", ref this.c, A_0);
			di7.ReadList<cze>("POA:POFJ", ref this.d, A_0);
			return;
		}
		this.c = new List<cze>();
		this.d = new List<cze>();
	}

	// Token: 0x06006BEE RID: 27630 RVA: 0x002D520C File Offset: 0x002D340C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("POA:P", this.a);
		di7.WriteList<string>("POA:PS", this.b, info);
		di7.WriteList<cze>("POA:PONJ", this.c, info);
		di7.WriteList<cze>("POA:POFJ", this.d, info);
	}

	// Token: 0x06006BEF RID: 27631 RVA: 0x002D526C File Offset: 0x002D346C
	public List<string> g()
	{
		return this.b;
	}

	// Token: 0x06006BF0 RID: 27632 RVA: 0x002D5274 File Offset: 0x002D3474
	public void a(List<string> A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06006BF1 RID: 27633 RVA: 0x002D5280 File Offset: 0x002D3480
	public bool? e()
	{
		return this.a;
	}

	// Token: 0x06006BF2 RID: 27634 RVA: 0x002D5288 File Offset: 0x002D3488
	public void a(bool? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06006BF3 RID: 27635 RVA: 0x002D5294 File Offset: 0x002D3494
	public List<cze> d()
	{
		return this.c;
	}

	// Token: 0x06006BF4 RID: 27636 RVA: 0x002D529C File Offset: 0x002D349C
	public void a(List<cze> A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06006BF5 RID: 27637 RVA: 0x002D52A8 File Offset: 0x002D34A8
	public List<cze> f()
	{
		return this.d;
	}

	// Token: 0x06006BF6 RID: 27638 RVA: 0x002D52B0 File Offset: 0x002D34B0
	public void b(List<cze> A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06006BF7 RID: 27639 RVA: 0x002D52BC File Offset: 0x002D34BC
	public dt5(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006BF8 RID: 27640 RVA: 0x002D52E8 File Offset: 0x002D34E8
	public void mx()
	{
		this.h();
		this.b();
	}

	// Token: 0x06006BF9 RID: 27641 RVA: 0x002D52F8 File Offset: 0x002D34F8
	public void my()
	{
	}

	// Token: 0x06006BFA RID: 27642 RVA: 0x002D52FC File Offset: 0x002D34FC
	public void b()
	{
		e3l e3l = base.a8().GetAspect<e3l>();
		if (e3l == null)
		{
			e3l = new e3l(base.a8());
			base.a8().SetAspect<e3l>(e3l);
		}
		for (int i = e3l.a.Count - 1; i >= 0; i--)
		{
			if (e3l.a[i].StartsWith(bp5.g))
			{
				e3l.a.RemoveAt(i);
			}
		}
		e3l.a.AddRange(Enumerable.Select<string, string>(this.b, new Func<string, string>(dt5.a.a.a)));
		e3l.a();
	}

	// Token: 0x06006BFB RID: 27643 RVA: 0x002D53B4 File Offset: 0x002D35B4
	public void h()
	{
		cnk service = bpo.GetService<cnk>();
		if (service != null && service.aqu() != null)
		{
			bool? flag = this.a;
			this.a = new bool?(true);
			foreach (string a_ in this.b)
			{
				if (a_ == "none" || !service.aqu().r().GetPrimitivePropertyValue<bool>(bp5.f(a_), new bool?(false)).Value)
				{
					this.a = new bool?(false);
					break;
				}
			}
			if (flag == null || flag.Value != this.a.Value)
			{
				if (!this.a.Value)
				{
					this.a();
				}
				foreach (cze a_2 in (this.a.Value ? this.c : this.d))
				{
					base.a8().Zone.ActionManager.g9(new a4s(a_2, null, new ar7(base.a8()), null), atp.a);
				}
				foreach (cn7 cn in Enumerable.ToList<cn7>(Enumerable.Where<cn7>(base.a8().Aspects, new Func<cn7, bool>(dt5.a.a.a))))
				{
					((d9i)cn).pt(this.a.Value);
				}
			}
		}
	}

	// Token: 0x06006BFC RID: 27644 RVA: 0x002D55D0 File Offset: 0x002D37D0
	private void a()
	{
		ps service = bpo.GetService<ps>();
		if (service != null && service.aky() != null && service.aky().ny() == base.a8() && base.a8().s.b != null && !base.a8().s.b.z())
		{
			service.aky().ad();
		}
	}

	// Token: 0x04002C4C RID: 11340
	private bool? a;

	// Token: 0x04002C4D RID: 11341
	private List<string> b = new List<string>();

	// Token: 0x04002C4E RID: 11342
	private List<cze> c = new List<cze>();

	// Token: 0x04002C4F RID: 11343
	private List<cze> d = new List<cze>();

	// Token: 0x020012F8 RID: 4856
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06006BFF RID: 27647 RVA: 0x002D5658 File Offset: 0x002D3858
		internal string a(string A_0)
		{
			return bp5.g(A_0);
		}

		// Token: 0x06006C00 RID: 27648 RVA: 0x002D5660 File Offset: 0x002D3860
		internal bool a(cn7 A_0)
		{
			return A_0 is d9i;
		}

		// Token: 0x04002C50 RID: 11344
		public static readonly dt5.a a = new dt5.a();

		// Token: 0x04002C51 RID: 11345
		public static Func<string, string> b;

		// Token: 0x04002C52 RID: 11346
		public static Func<cn7, bool> c;
	}
}
