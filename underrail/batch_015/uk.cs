using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001111 RID: 4369
[eiz("DEJ")]
[Serializable]
public sealed class uk : cze, ISerializable
{
	// Token: 0x06005D01 RID: 23809 RVA: 0x0027A3E8 File Offset: 0x002785E8
	private uk(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = (bvl)A_0.GetValue("DEJ:T", typeof(bvl));
		if (ell.a() >= 32)
		{
			this.a = (A_0.GetValue("DEJ:CT", typeof(Guid?)) as Guid?);
		}
		if (ell.a() >= 208)
		{
			this.c = A_0.GetBoolean("DEJ:D");
			this.d = A_0.GetBoolean("DEJ:S");
		}
		if (ell.a() >= 326)
		{
			this.e = A_0.GetBoolean("DEJ:MD");
		}
	}

	// Token: 0x06005D02 RID: 23810 RVA: 0x0027A4B0 File Offset: 0x002786B0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("DEJ:T", this.b);
		info.AddValue("DEJ:CT", this.a);
		info.AddValue("DEJ:D", this.c);
		info.AddValue("DEJ:S", this.d);
		info.AddValue("DEJ:MD", this.e);
	}

	// Token: 0x06005D03 RID: 23811 RVA: 0x0027A524 File Offset: 0x00278724
	public bvl c()
	{
		return this.b;
	}

	// Token: 0x06005D04 RID: 23812 RVA: 0x0027A52C File Offset: 0x0027872C
	public void a(bvl A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005D05 RID: 23813 RVA: 0x0027A538 File Offset: 0x00278738
	public Guid? b()
	{
		return this.a;
	}

	// Token: 0x06005D06 RID: 23814 RVA: 0x0027A540 File Offset: 0x00278740
	public void a(Guid? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005D07 RID: 23815 RVA: 0x0027A54C File Offset: 0x0027874C
	public bool d()
	{
		return this.c;
	}

	// Token: 0x06005D08 RID: 23816 RVA: 0x0027A554 File Offset: 0x00278754
	public void a(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005D09 RID: 23817 RVA: 0x0027A560 File Offset: 0x00278760
	public bool a()
	{
		return this.d;
	}

	// Token: 0x06005D0A RID: 23818 RVA: 0x0027A568 File Offset: 0x00278768
	public void c(bool A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06005D0B RID: 23819 RVA: 0x0027A574 File Offset: 0x00278774
	public bool e()
	{
		return this.e;
	}

	// Token: 0x06005D0C RID: 23820 RVA: 0x0027A57C File Offset: 0x0027877C
	public void b(bool A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06005D0D RID: 23821 RVA: 0x0027A588 File Offset: 0x00278788
	public uk()
	{
	}

	// Token: 0x06005D0E RID: 23822 RVA: 0x0027A5A0 File Offset: 0x002787A0
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (this.a != null)
		{
			aud aud = null;
			if (A_0 != null)
			{
				aud = A_0.Area;
			}
			if (aud == null && A_1 != null)
			{
				aud = A_1.Area;
			}
			if (aud != null)
			{
				b0b b0b = aud.a(this.a.Value);
				if (b0b != null)
				{
					this.a(b0b);
				}
			}
			return;
		}
		switch (this.b)
		{
		case bvl.b:
			if (A_0 != null)
			{
				this.a(A_0);
				return;
			}
			break;
		case bvl.c:
			if (A_1 != null)
			{
				this.a(A_1);
			}
			break;
		case bvl.d:
			break;
		default:
			return;
		}
	}

	// Token: 0x06005D0F RID: 23823 RVA: 0x0027A63C File Offset: 0x0027883C
	public void a(b0b A_0)
	{
		aud a_ = A_0.Area;
		if (this.c)
		{
			A_0.w();
		}
		A_0.an();
		if (this.d)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				dqv aspect = A_0.GetAspect<dqv>();
				if (aspect != null)
				{
					if (this.e)
					{
						serviceOrThrow.aqu().b().a(aspect.a()).a(true);
					}
					serviceOrThrow.aru(aspect.a8(), a_);
				}
			}
		}
	}

	// Token: 0x0400251B RID: 9499
	private new Guid? a;

	// Token: 0x0400251C RID: 9500
	private bvl b = bvl.c;

	// Token: 0x0400251D RID: 9501
	private bool c = true;

	// Token: 0x0400251E RID: 9502
	private bool d;

	// Token: 0x0400251F RID: 9503
	private bool e;
}
