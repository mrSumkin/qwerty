using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001B44 RID: 6980
[eiz("CSE1")]
[Serializable]
public sealed class b34 : els, ISerializable
{
	// Token: 0x060096F2 RID: 38642 RVA: 0x003AF890 File Offset: 0x003ADA90
	private b34(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.d = (i0)A_0.GetValue("CSE1:MMSE", typeof(i0));
		if (ell.a() >= 257)
		{
			this.e = (ba)A_0.GetValue("CSE1:P", typeof(ba));
		}
	}

	// Token: 0x060096F3 RID: 38643 RVA: 0x003AF8F4 File Offset: 0x003ADAF4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CSE1:MMSE", this.d);
		info.AddValue("CSE1:P", this.e);
	}

	// Token: 0x060096F4 RID: 38644 RVA: 0x003AF920 File Offset: 0x003ADB20
	public b34(int A_0, int A_1) : base(b34.c, "Переохлаждение", ci8.c)
	{
		base.Duration = A_0;
		base.TickPeriod = 0;
		base.Icon = "Psi.Cryokinesis";
		base.VisualEffects.Add(new ud(this, "Chilled"));
		base.MaxStacks = A_1;
		base.Stacking = axm.b;
		this.d = new i0(-b34.b, false, false, false);
		this.e = new ba(-b34.a, false, true, false);
		base.StaticEffects.Add(this.d);
		base.StaticEffects.Add(this.e);
	}

	// Token: 0x060096F5 RID: 38645 RVA: 0x003AF9C8 File Offset: 0x003ADBC8
	public override string cb(ll A_0)
	{
		if (A_0 != null && A_0.a().d(CharacterImmunities.Slow))
		{
			return qv.b("StatusEffects/Chilled-SlowImmune");
		}
		return qv.a("StatusEffects/Chilled", new object[]
		{
			base.Stacks * b34.a
		});
	}

	// Token: 0x060096F6 RID: 38646 RVA: 0x003AFA20 File Offset: 0x003ADC20
	protected override void c8()
	{
		this.d.Amount = (float)base.Stacks * -b34.b;
		this.e.a = base.Stacks * -b34.a;
	}

	// Token: 0x04003A11 RID: 14865
	public new static readonly int a = 10;

	// Token: 0x04003A12 RID: 14866
	public static readonly float b = 0.15f;

	// Token: 0x04003A13 RID: 14867
	public new static readonly string c = "chilled";

	// Token: 0x04003A14 RID: 14868
	private new i0 d;

	// Token: 0x04003A15 RID: 14869
	private new ba e;
}
