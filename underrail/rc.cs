using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;

// Token: 0x02001335 RID: 4917
[eiz("PA")]
[Serializable]
public sealed class rc : b1z, csy, ISerializable
{
	// Token: 0x06006F5C RID: 28508 RVA: 0x002EC1E8 File Offset: 0x002EA3E8
	private rc(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (EntityAspectReference<amc, amc>)A_0.GetValue("PA:P", typeof(EntityAspectReference<amc, amc>));
		this.b = (EntityAspectReference<amc, amc>)A_0.GetValue("PA:T", typeof(EntityAspectReference<amc, amc>));
	}

	// Token: 0x06006F5D RID: 28509 RVA: 0x002EC240 File Offset: 0x002EA440
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PA:P", this.a);
		info.AddValue("PA:T", this.b);
	}

	// Token: 0x06006F5E RID: 28510 RVA: 0x002EC26C File Offset: 0x002EA46C
	public amc c()
	{
		if (this.b != null)
		{
			return this.b.ao();
		}
		return null;
	}

	// Token: 0x06006F5F RID: 28511 RVA: 0x002EC288 File Offset: 0x002EA488
	public amc d()
	{
		if (this.a != null)
		{
			return this.a.ao();
		}
		return null;
	}

	// Token: 0x06006F60 RID: 28512 RVA: 0x002EC2A4 File Offset: 0x002EA4A4
	public override m7 kh()
	{
		return m7.b | m7.g | m7.i;
	}

	// Token: 0x06006F61 RID: 28513 RVA: 0x002EC2AC File Offset: 0x002EA4AC
	public rc(amc A_0, amc A_1)
	{
		this.a = new EntityAspectReference<amc, amc>(A_0);
		this.b = new EntityAspectReference<amc, amc>(A_1);
	}

	// Token: 0x06006F62 RID: 28514 RVA: 0x002EC2CC File Offset: 0x002EA4CC
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (!this.b())
		{
			base.j();
			return dc4.e;
		}
		if (aw1.b(this.a.ao().a8(), this.b.ao().a8()) > 1.8)
		{
			base.j();
			return dc4.c;
		}
		return dc4.b;
	}

	// Token: 0x06006F63 RID: 28515 RVA: 0x002EC328 File Offset: 0x002EA528
	private bool b()
	{
		return this.a != null && this.a.ao() != null && this.a.ao().a8() != null && this.a.ao().a8().j == cgy.b && this.b != null && this.b.ao() != null && this.b.ao().a8() != null && this.b.ao().a8().j == cgy.b && this.b.ao().a8().t.b != null;
	}

	// Token: 0x06006F64 RID: 28516 RVA: 0x002EC3EC File Offset: 0x002EA5EC
	private void a(coh A_0)
	{
		a7v.a(new h0("Вы успешно украли предмет.", new Color?(adi.o)));
		a7v.a(new bou(A_0));
		bmj.a(this.a.ao().a8(), new d53("Успех", adi.o, null, false));
	}

	// Token: 0x06006F65 RID: 28517 RVA: 0x002EC444 File Offset: 0x002EA644
	private void a()
	{
		a7v.a(new h0("Вас поймали на карманной краже!", new Color?(Color.Red)));
		bmj.a(this.a.ao().a8(), new d53("Неудача", Color.Red, null, false));
	}

	// Token: 0x06006F66 RID: 28518 RVA: 0x002EC490 File Offset: 0x002EA690
	public bool ki(dbi A_0, coh A_1, object A_2)
	{
		return false;
	}

	// Token: 0x06006F67 RID: 28519 RVA: 0x002EC494 File Offset: 0x002EA694
	public bool kj(dbi A_0, coh A_1, object A_2)
	{
		if (!this.b())
		{
			return false;
		}
		double a_ = 1.0;
		if (this.d().aa().Feats.Contains<b1w>())
		{
			bm6 bm = this.c().a8().t.b;
			if (bm != null && !bm.a(this.d()))
			{
				a_ = 1.0 - ((double)b1w.b + (double)this.d().aa().GetSpecializationValue<bh5>(true) * bh5.a);
			}
		}
		if (b87.b(this.a.ao().aa(), this.b.ao().aa(), A_1, a_))
		{
			A_1.Stealable = true;
			this.a(A_1);
			if (this.a.ao().aa() is e3q)
			{
				cxc.a(eyy.bo);
			}
			return true;
		}
		awq.a(this.a.ao().a8(), this.b.ao().a8(), true, false, true, true, false, false);
		this.a();
		base.j();
		return false;
	}

	// Token: 0x06006F68 RID: 28520 RVA: 0x002EC5C4 File Offset: 0x002EA7C4
	public void kk(dbi A_0, coh A_1, object A_2)
	{
	}

	// Token: 0x06006F69 RID: 28521 RVA: 0x002EC5C8 File Offset: 0x002EA7C8
	public void kl(dbi A_0, coh A_1, object A_2)
	{
	}

	// Token: 0x04002D8B RID: 11659
	private new EntityAspectReference<amc, amc> a;

	// Token: 0x04002D8C RID: 11660
	private EntityAspectReference<amc, amc> b;

	// Token: 0x04002D8D RID: 11661
	private const int c = 2500;
}
