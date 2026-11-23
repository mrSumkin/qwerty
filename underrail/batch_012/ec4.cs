using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.Space;

// Token: 0x02001AB4 RID: 6836
[eiz("PKCLSE")]
[Serializable]
public sealed class ec4 : els, ISerializable
{
	// Token: 0x06009440 RID: 37952 RVA: 0x003A5A80 File Offset: 0x003A3C80
	private ec4(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = (Guid)A_0.GetValue("PKCLSE:I", typeof(Guid));
		this.c = A_0.GetValue("PKCLSE:W", typeof(object));
		this.d = A_0.GetValue("PKCLSE:P", typeof(object));
		this.e = A_0.GetValue("PKCLSE:N", typeof(object));
		this.f = A_0.GetDouble("PKCLSE:J");
		this.g = A_0.GetInt32("PKCLSE:M");
	}

	// Token: 0x06009441 RID: 37953 RVA: 0x003A5B28 File Offset: 0x003A3D28
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PKCLSE:I", this.b);
		info.AddValue("PKCLSE:W", this.c);
		info.AddValue("PKCLSE:P", this.d);
		info.AddValue("PKCLSE:N", this.e);
		info.AddValue("PKCLSE:J", this.f);
		info.AddValue("PKCLSE:M", this.g);
	}

	// Token: 0x06009442 RID: 37954 RVA: 0x003A5BA8 File Offset: 0x003A3DA8
	public ec4(int A_0, object A_1, object A_2, object A_3, double A_4, int A_5) : base(ec4.a, "Звено психокинетической цепи", ci8.c)
	{
		base.Duration = A_0;
		base.TickPeriod = d0u.b;
		base.Icon = "Psi.PsychokineticChain";
		base.VisualEffects.Add(new ud(this, "PsychokineticChainLink"));
		base.MaxStacks = 1;
		base.Stacking = axm.c;
		this.af = "PsychokineticChain_LinkCarrierDamaged";
		this.ad = "PsychokineticChain_LinkHearbeat";
		this.ab = "PsychokineticChain_LinkSoundOn";
		this.aa = "PsychokineticChain_LinkSoundOff";
		this.y = "PsychokineticChain_LinkSoundOff";
		this.w = "PsychokineticChain_LinkSoundOn";
		this.x = "PsychokineticChain_LinkSoundOff";
		this.c = A_1;
		this.d = A_2;
		this.e = A_3;
		this.f = A_4;
		this.g = A_5;
	}

	// Token: 0x06009443 RID: 37955 RVA: 0x003A5C7C File Offset: 0x003A3E7C
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/PsychokineticChainLink", new object[]
		{
			Convert.ToInt32(this.f * 100.0),
			this.g
		});
	}

	// Token: 0x040038FD RID: 14589
	public new static readonly string a = "psychokineticChainLink";

	// Token: 0x040038FE RID: 14590
	public Guid b;

	// Token: 0x040038FF RID: 14591
	public new object c;

	// Token: 0x04003900 RID: 14592
	public new object d;

	// Token: 0x04003901 RID: 14593
	public new object e;

	// Token: 0x04003902 RID: 14594
	public double f;

	// Token: 0x04003903 RID: 14595
	public int g;

	// Token: 0x04003904 RID: 14596
	[NonSerialized]
	public HorizontalDirection h;

	// Token: 0x04003905 RID: 14597
	[NonSerialized]
	public new HorizontalDirection i;
}
