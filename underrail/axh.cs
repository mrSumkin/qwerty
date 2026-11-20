using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;

// Token: 0x020012FD RID: 4861
[eiz("PSA")]
[Serializable]
public sealed class axh : Aspect<c5x>, bp1, d9i
{
	// Token: 0x06006C41 RID: 27713 RVA: 0x002D6828 File Offset: 0x002D4A28
	private axh(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("PSA:E");
		this.b = A_0.GetBoolean("PSA:EF");
		this.c = A_0.GetBoolean("PSA:PL");
		this.d = A_0.GetString("PSA:PSN");
		if (ell.a() >= 38)
		{
			this.e = A_0.GetBoolean("PSA:D");
		}
	}

	// Token: 0x06006C42 RID: 27714 RVA: 0x002D68A8 File Offset: 0x002D4AA8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PSA:E", this.a);
		info.AddValue("PSA:EF", this.b);
		info.AddValue("PSA:PL", this.c);
		info.AddValue("PSA:PSN", this.d);
		info.AddValue("PSA:D", this.e);
	}

	// Token: 0x06006C43 RID: 27715 RVA: 0x002D6914 File Offset: 0x002D4B14
	public bool i()
	{
		return this.a;
	}

	// Token: 0x06006C44 RID: 27716 RVA: 0x002D691C File Offset: 0x002D4B1C
	public bool f()
	{
		return this.b;
	}

	// Token: 0x06006C45 RID: 27717 RVA: 0x002D6924 File Offset: 0x002D4B24
	public bool g()
	{
		return this.c;
	}

	// Token: 0x06006C46 RID: 27718 RVA: 0x002D692C File Offset: 0x002D4B2C
	public void b(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06006C47 RID: 27719 RVA: 0x002D6938 File Offset: 0x002D4B38
	public string h()
	{
		return this.d;
	}

	// Token: 0x06006C48 RID: 27720 RVA: 0x002D6940 File Offset: 0x002D4B40
	public void a(string A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06006C49 RID: 27721 RVA: 0x002D694C File Offset: 0x002D4B4C
	public bool e()
	{
		return this.e;
	}

	// Token: 0x06006C4A RID: 27722 RVA: 0x002D6954 File Offset: 0x002D4B54
	public void a(bool A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06006C4B RID: 27723 RVA: 0x002D6960 File Offset: 0x002D4B60
	public axh(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006C4C RID: 27724 RVA: 0x002D6970 File Offset: 0x002D4B70
	public void mx()
	{
		this.b();
	}

	// Token: 0x06006C4D RID: 27725 RVA: 0x002D6978 File Offset: 0x002D4B78
	public void my()
	{
		this.f = false;
	}

	// Token: 0x06006C4E RID: 27726 RVA: 0x002D6984 File Offset: 0x002D4B84
	public void a(c5x A_0)
	{
		this.a(A_0, !this.a, null);
	}

	// Token: 0x06006C4F RID: 27727 RVA: 0x002D69AC File Offset: 0x002D4BAC
	public void a(c5x A_0, bool A_1, bool? A_2 = null)
	{
		if (!this.f)
		{
			this.b();
		}
		bool flag = this.a;
		bool flag2 = this.b;
		this.a = A_1;
		if (A_2 != null)
		{
			this.b = (this.a && (!this.c || A_2.Value));
		}
		else
		{
			this.b = (this.a && (!this.c || this.a()));
		}
		this.d();
		if (this.b != flag2 || this.a != flag)
		{
			foreach (cn7 cn in Enumerable.ToList<cn7>(Enumerable.Where<cn7>(base.a8().Aspects, new Func<cn7, bool>(axh.a.a.a))))
			{
				((g3)cn).aal(A_0, this.a, this.b);
			}
		}
		if (this.b != flag2 && base.a8().Zone != null)
		{
			d60 d = base.a8().Zone.a();
			if (d != null)
			{
				foreach (b0b b0b in d.ab2(new List<string>
				{
					bp5.g(this.d)
				}))
				{
					dt5 aspect = b0b.GetAspect<dt5>();
					if (aspect != null)
					{
						aspect.h();
					}
				}
			}
		}
	}

	// Token: 0x06006C50 RID: 27728 RVA: 0x002D6B98 File Offset: 0x002D4D98
	public void pt(bool A_0)
	{
		if (!this.f)
		{
			this.b();
		}
		if (this.c && A_0 != this.b)
		{
			this.a(null, this.a, new bool?(A_0));
		}
	}

	// Token: 0x06006C51 RID: 27729 RVA: 0x002D6BD8 File Offset: 0x002D4DD8
	private void d()
	{
		if (!string.IsNullOrEmpty(this.d))
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				serviceOrThrow.aqu().r().SetPropertyValue(bp5.g(this.d), this.a);
				serviceOrThrow.aqu().r().SetPropertyValue(bp5.f(this.d), this.b);
			}
		}
	}

	// Token: 0x06006C52 RID: 27730 RVA: 0x002D6C54 File Offset: 0x002D4E54
	private void b()
	{
		this.f = true;
		cnk service = bpo.GetService<cnk>();
		if (service != null && service.aqu() != null && !string.IsNullOrEmpty(this.d))
		{
			bool? primitivePropertyValue = service.aqu().r().GetPrimitivePropertyValue<bool>(bp5.g(this.d), null);
			if (primitivePropertyValue == null)
			{
				primitivePropertyValue = new bool?(this.e);
			}
			this.a(null, primitivePropertyValue.Value, null);
		}
	}

	// Token: 0x06006C53 RID: 27731 RVA: 0x002D6CE4 File Offset: 0x002D4EE4
	private bool a()
	{
		dt5 aspect = base.a8().GetAspect<dt5>();
		return aspect == null || (aspect.e() != null && aspect.e().Value);
	}

	// Token: 0x04002C71 RID: 11377
	private bool a;

	// Token: 0x04002C72 RID: 11378
	private bool b;

	// Token: 0x04002C73 RID: 11379
	private bool c = true;

	// Token: 0x04002C74 RID: 11380
	private string d;

	// Token: 0x04002C75 RID: 11381
	private bool e;

	// Token: 0x04002C76 RID: 11382
	[NonSerialized]
	private bool f;

	// Token: 0x020012FE RID: 4862
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06006C56 RID: 27734 RVA: 0x002D6D3C File Offset: 0x002D4F3C
		internal bool a(cn7 A_0)
		{
			return A_0 is g3;
		}

		// Token: 0x04002C77 RID: 11383
		public static readonly axh.a a = new axh.a();

		// Token: 0x04002C78 RID: 11384
		public static Func<cn7, bool> b;
	}
}
