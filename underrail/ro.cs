using System;
using System.Runtime.Serialization;

// Token: 0x02001AAE RID: 6830
[eiz("TKGSE")]
[Serializable]
public sealed class ro : els, ISerializable
{
	// Token: 0x06009428 RID: 37928 RVA: 0x003A5654 File Offset: 0x003A3854
	private ro(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009429 RID: 37929 RVA: 0x003A5660 File Offset: 0x003A3860
	public ro(int A_0, int A_1) : base(ro.a, "Телекинетическое заземление", ci8.c)
	{
		base.Icon = "Psi.TelekineticGrounding";
		base.VisualEffects.Add(new ud(this, "TelekineticGrounding"));
		this.z = "TelekineticGrounding_Tick";
		base.Duration = A_0;
		base.StaticEffects.Add(new ap0());
		this.ab = "TelekineticGrounding_SoundOn";
		this.aa = "TelekineticGrounding_SoundOff";
		this.y = "TelekineticGrounding_SoundOff";
		this.w = "TelekineticGrounding_SoundOn";
		this.x = "TelekineticGrounding_SoundOff";
		this.b = A_1;
	}

	// Token: 0x0600942A RID: 37930 RVA: 0x003A5700 File Offset: 0x003A3900
	public override string cb(ll A_0)
	{
		return qv.b("StatusEffects/TelekineticGrounding");
	}

	// Token: 0x040038F1 RID: 14577
	public new static readonly string a = "telekineticGrounding";

	// Token: 0x040038F2 RID: 14578
	public int b;
}
