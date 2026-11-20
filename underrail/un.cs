using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;

// Token: 0x02000984 RID: 2436
[eiz("TCHSIF")]
[Serializable]
public sealed class un : bdw, ISerializable
{
	// Token: 0x06003B0B RID: 15115 RVA: 0x0015E494 File Offset: 0x0015C694
	private un(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003B0C RID: 15116 RVA: 0x0015E49C File Offset: 0x0015C69C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003B0D RID: 15117 RVA: 0x0015E4A0 File Offset: 0x0015C6A0
	public un()
	{
	}

	// Token: 0x06003B0E RID: 15118 RVA: 0x0015E4AC File Offset: 0x0015C6AC
	public void av(c1a A_0, cyt A_1)
	{
		string[] array = new string[]
		{
			"creature\\Faceless\\FacelessSoldier-AssaultRifle",
			"creature\\Faceless\\FacelessSoldier-EnergyPistol",
			"creature\\Faceless\\FacelessSoldier-Sledgehammer",
			"creature\\Faceless\\FacelessSoldier-Smg",
			"creatures\\Faceless\\FacelessDoctor",
			"creatures\\Faceless\\FacelessDoctor",
			"creatures\\Faceless\\FacelessCentaur",
			"creatures\\Faceless\\FacelessCentaur",
			"creatures\\Faceless\\FacelessMindreader",
			"creatures\\Faceless\\FacelessMindreader",
			"creatures\\Faceless\\AugmentedRathound",
			"creatures\\Faceless\\AugmentedRathound"
		};
		foreach (csd csd in A_0.Waypoints)
		{
			if (csd.Name.StartsWith("facelessGuard"))
			{
				bt4 bt = new bt4(csd.Name);
				aud aud;
				Vector3 a_;
				HorizontalDirection horizontalDirection;
				bt.a(A_0, out aud, out a_, out horizontalDirection);
				ak1 ak = aud.a(a_.a());
				if (ak != null && !aw1.a(null, ak, false, null))
				{
					c5x c5x = vq.a(array[cuo.a.Next(array.Length)], csd, false);
					if (c5x != null && c5x.t.b != null)
					{
						c5x.t.b.y6()[ddq.ay] = bt;
					}
				}
			}
		}
		d60 addon = A_0.GetAddon<d60>();
		if (addon != null)
		{
			foreach (b0b b0b in addon.ab4(new string[]
			{
				"facelessDoor"
			}))
			{
				cnb cnb = b0b.GetAspect<bim>() as cnb;
				d2b aspect = b0b.GetAspect<d2b>();
				if (aspect != null)
				{
					aspect.a(false, false);
				}
				if (cnb != null)
				{
					if (cnb.o())
					{
						cnb.d(true);
					}
					else
					{
						cnb.a(null, null, false, false);
					}
				}
			}
			foreach (b0b b0b2 in addon.ab4(new string[]
			{
				"facelessSplitGate"
			}))
			{
				cd0 aspect2 = b0b2.GetAspect<cd0>();
				if (aspect2 != null)
				{
					aspect2.b = new Point(5, 0);
					b0b2.TileFormationModifiers.c();
					b0b2.z();
				}
				ny aspect3 = b0b2.GetAspect<ny>();
				if (aspect3 != null)
				{
					aspect3.a(false, true);
				}
			}
		}
	}
}
