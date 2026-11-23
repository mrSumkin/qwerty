using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;

// Token: 0x02000A72 RID: 2674
[eiz("MHDJ")]
[Serializable]
public sealed class eof : cze, ISerializable
{
	// Token: 0x06003F0B RID: 16139 RVA: 0x0017D6D8 File Offset: 0x0017B8D8
	private eof(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003F0C RID: 16140 RVA: 0x0017D6E4 File Offset: 0x0017B8E4
	public eof()
	{
	}

	// Token: 0x06003F0D RID: 16141 RVA: 0x0017D6F0 File Offset: 0x0017B8F0
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && A_1 is c5x)
		{
			serviceOrThrow.aqu().r()["dc_mushroomHeartDestroyed"] = true;
			Vector3 vector = A_1.Location;
			aud aud = A_1.Area;
			c5x c5x = vq.a("object\\natural\\DeadMushroomHeart", aud.Zone, new bt4(aud.y8(), vector), false);
			if (c5x != null && c5x.o.b != null && c5x.i.b != null)
			{
				c5x c5x2 = new c5x();
				c5x2.Layer = aju.x;
				c5x2.q("Пролезть");
				c5x2.Location = vector;
				c5x2.Size = A_1.Size;
				c5x2.SetAspect<cd0>(new cd0(c5x2)
				{
					d = new float?(0f),
					a = "Objects\\Natural\\MushroomHeartClimb",
					b = new Point(0, 0)
				});
				bim bim = new bim(c5x2);
				bim.a(new List<HorizontalDirection>
				{
					HorizontalDirection.South
				});
				bim.s().Add(new e68
				{
					Destination = new c2w("dc-f4", "FromDown")
				});
				c5x2.SetAspect<bim>(bim);
				c5x c5x3 = new c5x();
				c5x3.Layer = aju.x;
				c5x3.q("Cavity");
				c5x3.Location = vector;
				c5x3.Size = A_1.Size;
				c5x3.SetAspect<cd0>(new cd0(c5x3)
				{
					d = new float?(0f),
					a = "Objects\\Natural\\MushroomHeartCavity",
					b = new Point(0, 0)
				});
				c7j c7j = new c7j(c5x3);
				c7j.a(new List<HorizontalDirection>
				{
					HorizontalDirection.South
				});
				c7j.ItemContainer.z3(new d48(ez2.CreateDefinitonProvider<x2>("Oddities\\GiantTick")), true);
				c5x3.SetAspect<bim>(c7j);
				c5x c5x4 = new c5x();
				c5x4.Layer = aju.x;
				c5x4.q("Heart-like organ");
				c5x4.Location = vector;
				c5x4.Size = A_1.Size;
				c5x4.SetAspect<cd0>(new cd0(c5x4)
				{
					a = "Objects\\Natural\\MushroomHeartItem",
					b = new Point(0, 0)
				});
				bim bim2 = new bim(c5x4);
				mk mk = new mk();
				mk.GiveTo = bvl.b;
				mk.StaticItems.z3(new d48(ez2.CreateDefinitonProvider<dj3>("plot\\MushroomHeart")), true);
				bim2.af2(true);
				bim2.s().Add(mk);
				List<cze> list = bim2.s();
				bfq bfq = new bfq("CarcassOpen");
				bfq.a(bvl.b);
				list.Add(bfq);
				List<cze> list2 = bim2.s();
				uk uk = new uk();
				uk.a(bvl.c);
				list2.Add(uk);
				bim2.a(new List<HorizontalDirection>
				{
					HorizontalDirection.South
				});
				c5x4.SetAspect<bim>(bim2);
				awx awx = new awx();
				awx awx2 = awx;
				awx2.a(awx2.kh() | (m7.b | m7.k));
				awx.a(false);
				dqm dqm = new dqm(c5x.o.b);
				dqm.b(0);
				dqm.c(7);
				dqm.a(100.0);
				awx.ad().Add(dqm);
				awx.ad().Add(new a4s(new bk6(aud, c5x2), null, null, null));
				awx.ad().Add(new a4s(new bk6(aud, c5x3), null, null, null));
				awx.ad().Add(new a4s(new bk6(aud, c5x4), null, null, null));
				c5x.i.b.b(awx, atp.a);
			}
		}
	}
}
