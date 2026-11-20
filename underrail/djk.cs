using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x0200135B RID: 4955
[eiz("TTTA")]
[Serializable]
public sealed class djk : em1, ISerializable
{
	// Token: 0x06007067 RID: 28775 RVA: 0x002F36F8 File Offset: 0x002F18F8
	private djk(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (edx)A_0.GetValue("TTTA:DTR", typeof(edx));
			this.b = A_0.GetDouble("TTTA:T");
			return;
		}
		if (base.GetType() == typeof(djk))
		{
			this.a = (edx)A_0.GetValue("_DestinationTileRef", typeof(edx));
			this.j = A_0.GetInt32("_CurrentAttempt");
			return;
		}
		this.a = (edx)A_0.GetValue("TrekToTileAction+_DestinationTileRef", typeof(edx));
		this.j = A_0.GetInt32("TrekToTileAction+_CurrentAttempt");
	}

	// Token: 0x06007068 RID: 28776 RVA: 0x002F37C8 File Offset: 0x002F19C8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("TTTA:DTR", this.a);
		info.AddValue("TTTA:T", this.b);
	}

	// Token: 0x06007069 RID: 28777 RVA: 0x002F37F4 File Offset: 0x002F19F4
	private ak1 a()
	{
		return this.a.ao();
	}

	// Token: 0x0600706A RID: 28778 RVA: 0x002F3804 File Offset: 0x002F1A04
	public sealed override object fm()
	{
		return this.a();
	}

	// Token: 0x0600706B RID: 28779 RVA: 0x002F380C File Offset: 0x002F1A0C
	public double b()
	{
		return this.b;
	}

	// Token: 0x0600706C RID: 28780 RVA: 0x002F3814 File Offset: 0x002F1A14
	public void a(double A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600706D RID: 28781 RVA: 0x002F3820 File Offset: 0x002F1A20
	public djk(ale A_0, ak1 A_1) : base(A_0)
	{
		czh.a(A_1, "destinationTile");
		this.a = new edx(A_1);
		base.b(true);
	}

	// Token: 0x0600706E RID: 28782 RVA: 0x002F3848 File Offset: 0x002F1A48
	public static czp a(ale A_0, double A_1, ak1 A_2)
	{
		czp czp = new czp();
		czp.g = A_0;
		czp.n.a = true;
		czp.n.c = 3f;
		czp.o = ((A_1 == double.MaxValue) ? A_1 : (A_1 * 4.0));
		czp.f = true;
		if (A_2 != null)
		{
			czp.e = new ee4(A_2.Area.c(), new Point(A_2.Location.X * 4, A_2.Location.Y * 4));
		}
		em1.a(czp, A_0);
		return czp;
	}

	// Token: 0x0600706F RID: 28783 RVA: 0x002F38F0 File Offset: 0x002F1AF0
	protected override bool fn()
	{
		base.o();
		return true;
	}

	// Token: 0x06007070 RID: 28784 RVA: 0x002F38FC File Offset: 0x002F1AFC
	protected override void fo()
	{
		if (this.a() == null)
		{
			base.a(null);
			return;
		}
		wu serviceOrThrow = bpo.GetServiceOrThrow<wu>();
		czp a_ = djk.a(base.n(), this.b, this.a());
		eso a_2 = base.n().a8().IsPlayer ? eso.e : eso.d;
		c5w a_3 = serviceOrThrow.aki(a_, this.a().Playfield.PathProcessor, a_2);
		base.a(a_3);
	}

	// Token: 0x06007071 RID: 28785 RVA: 0x002F3980 File Offset: 0x002F1B80
	protected override void fp()
	{
		base.c(base.n().a8().l.Contains(this.a()) || (this.b > 0.0 && (double)bnx.a(base.n().a8().Location.a(), this.a().Location) <= this.b));
	}

	// Token: 0x04002DF9 RID: 11769
	private new edx a;

	// Token: 0x04002DFA RID: 11770
	private double b;
}
