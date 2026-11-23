using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;

// Token: 0x02001304 RID: 4868
[eiz("PEA")]
[Serializable]
public sealed class c3g : Aspect<c5x>, ISerializable
{
	// Token: 0x06006CB7 RID: 27831 RVA: 0x002D8018 File Offset: 0x002D6218
	private c3g(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			di7.ReadList<string>("PEA:O", ref this.a, A_0);
			di7.ReadList<string>("PEA:OF", ref this.b, A_0);
			di7.ReadList<string>("PEA:P", ref this.c, A_0);
			di7.ReadList<string>("PEA:PF", ref this.d, A_0);
			this.e = (c2n)A_0.GetValue("PEA:PBM", typeof(c2n));
			this.f = A_0.GetBoolean("PEA:SPE");
			return;
		}
		di7.ReadList<string>("PEA_O", ref this.a, A_0);
		di7.ReadList<string>("PEA_OF", ref this.b, A_0);
		di7.ReadList<string>("PEA_P", ref this.c, A_0);
		di7.ReadList<string>("PEA_PF", ref this.d, A_0);
		this.e = (c2n)A_0.GetValue("PEA_BM", typeof(c2n));
		this.f = A_0.GetBoolean("PEA_SPE");
	}

	// Token: 0x06006CB8 RID: 27832 RVA: 0x002D815C File Offset: 0x002D635C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<string>("PEA:O", this.a, info);
		di7.WriteList<string>("PEA:OF", this.b, info);
		di7.WriteList<string>("PEA:P", this.c, info);
		di7.WriteList<string>("PEA:PF", this.d, info);
		info.AddValue("PEA:PBM", this.e);
		info.AddValue("PEA:SPE", this.f);
	}

	// Token: 0x06006CB9 RID: 27833 RVA: 0x002D81DC File Offset: 0x002D63DC
	public List<string> f()
	{
		return this.a;
	}

	// Token: 0x06006CBA RID: 27834 RVA: 0x002D81E4 File Offset: 0x002D63E4
	public void b(List<string> A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06006CBB RID: 27835 RVA: 0x002D81F0 File Offset: 0x002D63F0
	public List<string> b()
	{
		return this.b;
	}

	// Token: 0x06006CBC RID: 27836 RVA: 0x002D81F8 File Offset: 0x002D63F8
	public void a(List<string> A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06006CBD RID: 27837 RVA: 0x002D8204 File Offset: 0x002D6404
	public List<string> g()
	{
		return this.c;
	}

	// Token: 0x06006CBE RID: 27838 RVA: 0x002D820C File Offset: 0x002D640C
	public void c(List<string> A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06006CBF RID: 27839 RVA: 0x002D8218 File Offset: 0x002D6418
	public List<string> d()
	{
		return this.d;
	}

	// Token: 0x06006CC0 RID: 27840 RVA: 0x002D8220 File Offset: 0x002D6420
	public void d(List<string> A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06006CC1 RID: 27841 RVA: 0x002D822C File Offset: 0x002D642C
	public c2n a()
	{
		return this.e;
	}

	// Token: 0x06006CC2 RID: 27842 RVA: 0x002D8234 File Offset: 0x002D6434
	public void a(c2n A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06006CC3 RID: 27843 RVA: 0x002D8240 File Offset: 0x002D6440
	public bool e()
	{
		return this.f;
	}

	// Token: 0x06006CC4 RID: 27844 RVA: 0x002D8248 File Offset: 0x002D6448
	public void a(bool A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06006CC5 RID: 27845 RVA: 0x002D8254 File Offset: 0x002D6454
	public c3g(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006CC6 RID: 27846 RVA: 0x002D82A4 File Offset: 0x002D64A4
	public void a(c3g A_0)
	{
		if (A_0 != null)
		{
			A_0.a = new List<string>(this.a);
			A_0.b = new List<string>(this.b);
			A_0.c = new List<string>(this.c);
			A_0.d = new List<string>(this.d);
			A_0.e = this.e;
			A_0.f = this.f;
		}
	}

	// Token: 0x06006CC7 RID: 27847 RVA: 0x002D8314 File Offset: 0x002D6514
	public bool a(amc A_0)
	{
		if (!this.a(A_0.aa()))
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				return this.a(serviceOrThrow.aqu().ac(), A_0);
			}
		}
		return false;
	}

	// Token: 0x06006CC8 RID: 27848 RVA: 0x002D8358 File Offset: 0x002D6558
	public bool a(efk A_0)
	{
		return this.a.Contains(A_0.Id) || this.b.Contains(A_0.FactionId) || this.c.Contains(A_0.Id) || this.d.Contains(A_0.FactionId);
	}

	// Token: 0x06006CC9 RID: 27849 RVA: 0x002D83BC File Offset: 0x002D65BC
	private bool a(oj A_0, amc A_1, amc A_2, object A_3)
	{
		if ((!string.IsNullOrEmpty(A_1.aa().FactionId) && this.d.Contains(A_1.aa().FactionId)) || (!string.IsNullOrEmpty(A_1.aa().Id) && this.c.Contains(A_1.aa().Id)))
		{
			h h = A_1.aa().a(A_0, A_2.aa().FactionId);
			if (!A_1.aa().Passive)
			{
				awq.a(A_1, A_2, true, true, null, true, true, false, false);
			}
			bm6 bm = A_1.a8().t.b;
			if (bm != null)
			{
				bm.a(A_2.a8());
			}
			h h2 = A_1.aa().a(A_0, A_2.aa().FactionId);
			if (A_1.a8() != null)
			{
				bb6 aspect = A_1.a8().GetAspect<bb6>();
				if (aspect != null)
				{
					aspect.a(A_2, base.a8(), h, h2);
				}
			}
			return h2 != h;
		}
		return false;
	}

	// Token: 0x06006CCA RID: 27850 RVA: 0x002D84D0 File Offset: 0x002D66D0
	private bool a(oj A_0, amc A_1)
	{
		bool result = false;
		if (this.e != c2n.a)
		{
			if (this.e == c2n.d)
			{
				using (List<string>.Enumerator enumerator = this.d.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						string a_ = enumerator.Current;
						A_0.aby(a_, A_1.aa().FactionId, c2n.d, (A_1.a8() != null) ? A_1.a8().Zone : null);
						result = true;
					}
					return result;
				}
			}
			if (this.e == c2n.c)
			{
				if (A_1.a8() == null || A_1.a8().Zone == null)
				{
					return result;
				}
				using (List<aud>.Enumerator enumerator2 = A_1.a8().Zone.Areas.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						aud aud = enumerator2.Current;
						foreach (b0b b0b in new List<b0b>(aud.Entities))
						{
							c5x c5x = b0b as c5x;
							if (c5x != null && c5x.h.b != null && c5x.h.b != A_1 && this.a(A_0, c5x.h.b, A_1, A_1.a8().Zone))
							{
								result = true;
							}
						}
					}
					return result;
				}
			}
			if (this.e == c2n.b && A_1.a8() != null && A_1.a8().Area != null)
			{
				foreach (b0b b0b2 in new List<b0b>(A_1.a8().Area.Entities))
				{
					c5x c5x2 = b0b2 as c5x;
					if (c5x2 != null && c5x2.h.b != null && c5x2.h.b != A_1 && c5x2.t.b != null && c5x2.t.b.b(A_1, false) && this.a(A_0, c5x2.h.b, A_1, A_1.a8().Zone))
					{
						result = true;
					}
				}
			}
		}
		return result;
	}

	// Token: 0x04002C96 RID: 11414
	private List<string> a = new List<string>();

	// Token: 0x04002C97 RID: 11415
	private List<string> b = new List<string>();

	// Token: 0x04002C98 RID: 11416
	private List<string> c = new List<string>();

	// Token: 0x04002C99 RID: 11417
	private List<string> d = new List<string>();

	// Token: 0x04002C9A RID: 11418
	private c2n e = c2n.b;

	// Token: 0x04002C9B RID: 11419
	private bool f = true;
}
