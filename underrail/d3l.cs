using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001A74 RID: 6772
[eiz("SMTRSE")]
[Serializable]
public sealed class d3l : els, ISerializable
{
	// Token: 0x06009310 RID: 37648 RVA: 0x003A0F84 File Offset: 0x0039F184
	private d3l(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009311 RID: 37649 RVA: 0x003A0F90 File Offset: 0x0039F190
	public d3l() : base("sensorimotorTransference", "Указания сенсомоторики", ci8.b)
	{
		base.Icon = "Status.135";
		base.Stacking = axm.b;
		base.MaxStacks = 5;
		foreach (csn csn in new axp().b)
		{
			if (csn is cxd)
			{
				base.StaticEffects.Add(new dpw(csn.Name, d3l.a));
			}
		}
		base.StaticEffects.Add(new ee8(-d3l.b, null));
		base.StaticEffects.Add(new bjo(-d3l.b, 0, null));
		foreach (object obj in Enum.GetValues(typeof(DamageType)))
		{
			DamageType a_ = (DamageType)obj;
			base.StaticEffects.Add(new e3r(a_, -d3l.c));
		}
	}

	// Token: 0x06009312 RID: 37650 RVA: 0x003A10D4 File Offset: 0x0039F2D4
	protected override void c8()
	{
		foreach (d3e d3e in base.StaticEffects)
		{
			dpw dpw = d3e as dpw;
			if (dpw != null)
			{
				dpw.a(d3l.a * base.Stacks);
			}
			else
			{
				ee8 ee = d3e as ee8;
				if (ee != null)
				{
					ee.a(-d3l.b * (float)base.Stacks);
				}
				else
				{
					bjo bjo = d3e as bjo;
					if (bjo != null)
					{
						bjo.WeaponSpeedModification = -d3l.b * (float)base.Stacks;
					}
					else
					{
						e3r e3r = d3e as e3r;
						if (e3r != null)
						{
							e3r.Value = -d3l.c * (double)base.Stacks;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009313 RID: 37651 RVA: 0x003A11C0 File Offset: 0x0039F3C0
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/SensorimotorTransference", new object[]
		{
			d3l.a * base.Stacks,
			(d3l.b * (float)base.Stacks).ToString("P0"),
			(d3l.c * (double)base.Stacks).ToString("P0")
		});
	}

	// Token: 0x04003876 RID: 14454
	public new static readonly int a = 10;

	// Token: 0x04003877 RID: 14455
	public static readonly float b = 0.1f;

	// Token: 0x04003878 RID: 14456
	public new static readonly double c = 0.10000000149011612;
}
