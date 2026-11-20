using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000FA4 RID: 4004
[eiz("SCA2")]
[Serializable]
public abstract class a6k : dvv, afq, ISerializable
{
	// Token: 0x060051CA RID: 20938 RVA: 0x0024C2A4 File Offset: 0x0024A4A4
	protected a6k(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (ad5)A_0.GetValue("SCA2:R", typeof(ad5));
			return;
		}
		if (base.GetType() == typeof(a6k))
		{
			this.a = (ad5)A_0.GetValue("_Root", typeof(ad5));
			return;
		}
		this.a = (ad5)A_0.GetValue("SpellComponentAction+_Root", typeof(ad5));
	}

	// Token: 0x060051CB RID: 20939 RVA: 0x0024C340 File Offset: 0x0024A540
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SCA2:R", this.a);
	}

	// Token: 0x060051CC RID: 20940 RVA: 0x0024C35C File Offset: 0x0024A55C
	public ad5 vg()
	{
		return this.a;
	}

	// Token: 0x060051CD RID: 20941 RVA: 0x0024C364 File Offset: 0x0024A564
	public void vh(ad5 A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060051CE RID: 20942 RVA: 0x0024C370 File Offset: 0x0024A570
	public virtual object fm()
	{
		if (this.a != null)
		{
			return this.a.h();
		}
		return null;
	}

	// Token: 0x060051CF RID: 20943 RVA: 0x0024C390 File Offset: 0x0024A590
	public virtual ci8? oi()
	{
		if (this.a != null && this.a.e() != null && this.a.e().p() != null)
		{
			return new ci8?(this.a.e().p().Nature);
		}
		return null;
	}

	// Token: 0x060051D0 RID: 20944 RVA: 0x0024C3F4 File Offset: 0x0024A5F4
	protected a6k(ad5 A_0)
	{
		czh.a(A_0, "root");
		this.a = A_0;
	}

	// Token: 0x060051D1 RID: 20945 RVA: 0x0024C410 File Offset: 0x0024A610
	protected a6k()
	{
	}

	// Token: 0x060051D2 RID: 20946 RVA: 0x0024C41C File Offset: 0x0024A61C
	protected ak1 i()
	{
		b0b b0b = this.vg().h() as b0b;
		if (b0b != null && b0b.j == cgy.b && b0b.Area != null)
		{
			Point a_ = b0b.aj().a();
			return b0b.Area.a(a_);
		}
		return null;
	}

	// Token: 0x0400218B RID: 8587
	private new ad5 a;
}
