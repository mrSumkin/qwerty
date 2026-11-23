using System;
using System.Runtime.Serialization;

// Token: 0x02001B37 RID: 6967
[eiz("NEE")]
[Serializable]
public sealed class bzi : els, ISerializable
{
	// Token: 0x060096AD RID: 38573 RVA: 0x003AE618 File Offset: 0x003AC818
	private bzi(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() >= 700)
		{
			this.a = A_0.GetBoolean("NEE:B");
		}
	}

	// Token: 0x060096AE RID: 38574 RVA: 0x003AE644 File Offset: 0x003AC844
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("NEE:B", this.a);
	}

	// Token: 0x060096AF RID: 38575 RVA: 0x003AE660 File Offset: 0x003AC860
	public bzi(int A_0, bool A_1 = false) : base("netEntanglement", "Опутывание", ci8.c)
	{
		this.a = A_1;
		base.Duration = A_0;
		if (A_1)
		{
			base.Icon = "BarbedThrowingNet";
		}
		else
		{
			base.Icon = "Devices.21";
		}
		if (A_1)
		{
			base.VisualEffects.Add(new ud(this, "BarbedNetEntanglement"));
		}
		else
		{
			base.VisualEffects.Add(new ud(this, "NetEntanglement"));
		}
		base.MaxStacks = 1;
		base.Stacking = axm.b;
		base.StaticEffects.Add(new ap0());
	}

	// Token: 0x060096B0 RID: 38576 RVA: 0x003AE704 File Offset: 0x003AC904
	public override string cb(ll A_0)
	{
		return qv.b("StatusEffects/NetEntanglement");
	}

	// Token: 0x040039F5 RID: 14837
	public new bool a;
}
