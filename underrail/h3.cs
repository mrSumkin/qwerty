using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;
using Ouroboros.Playfield.Space;

// Token: 0x02001682 RID: 5762
[eiz("GEAB")]
[Serializable]
public abstract class h3 : cuu, ISerializable
{
	// Token: 0x06007D9E RID: 32158 RVA: 0x0034FDFC File Offset: 0x0034DFFC
	protected h3(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = (cnm)A_0.GetValue("GEAB:P", typeof(cnm));
		this.b = (EntityAspectReference<amc, amc>)A_0.GetValue("GEAB:IR", typeof(EntityAspectReference<amc, amc>));
		if (ell.a() >= 551)
		{
			this.c = (A_0.GetValue("GEAB:S", typeof(edx)) as edx);
		}
	}

	// Token: 0x06007D9F RID: 32159 RVA: 0x0034FE80 File Offset: 0x0034E080
	public virtual void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("GEAB:P", this.a);
		info.AddValue("GEAB:IR", this.b);
		info.AddValue("GEAB:S", this.c);
	}

	// Token: 0x06007DA0 RID: 32160 RVA: 0x0034FEB8 File Offset: 0x0034E0B8
	public cnm d()
	{
		return this.a;
	}

	// Token: 0x06007DA1 RID: 32161 RVA: 0x0034FEC0 File Offset: 0x0034E0C0
	public void e(cnm A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06007DA2 RID: 32162 RVA: 0x0034FECC File Offset: 0x0034E0CC
	public EntityAspectReference<amc, amc> f()
	{
		return this.b;
	}

	// Token: 0x06007DA3 RID: 32163 RVA: 0x0034FED4 File Offset: 0x0034E0D4
	public void g(EntityAspectReference<amc, amc> A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06007DA4 RID: 32164 RVA: 0x0034FEE0 File Offset: 0x0034E0E0
	public amc c()
	{
		if (this.b != null)
		{
			return this.b.ao();
		}
		return null;
	}

	// Token: 0x06007DA5 RID: 32165 RVA: 0x0034FEFC File Offset: 0x0034E0FC
	public edx h()
	{
		return this.c;
	}

	// Token: 0x06007DA6 RID: 32166 RVA: 0x0034FF04 File Offset: 0x0034E104
	public void i(edx A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06007DA7 RID: 32167 RVA: 0x0034FF10 File Offset: 0x0034E110
	protected h3()
	{
	}

	// Token: 0x06007DA8 RID: 32168
	public abstract void cq(aud A_0, Point A_1, float A_2);

	// Token: 0x06007DA9 RID: 32169 RVA: 0x0034FF18 File Offset: 0x0034E118
	protected HorizontalDirection a(Point A_0)
	{
		if (this.c != null && this.c.ao() != null)
		{
			return bnx.a(this.c.ao().Location.a(), A_0.a());
		}
		return HorizontalDirection.North;
	}

	// Token: 0x040031A9 RID: 12713
	private cnm a;

	// Token: 0x040031AA RID: 12714
	private EntityAspectReference<amc, amc> b;

	// Token: 0x040031AB RID: 12715
	private edx c;
}
