using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Playfield.Space;

// Token: 0x020009BA RID: 2490
[eiz("FOSS")]
[Serializable]
public sealed class qm : bdw, ISerializable
{
	// Token: 0x06003BE4 RID: 15332 RVA: 0x00162284 File Offset: 0x00160484
	private qm(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003BE5 RID: 15333 RVA: 0x0016228C File Offset: 0x0016048C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003BE6 RID: 15334 RVA: 0x00162290 File Offset: 0x00160490
	public qm()
	{
	}

	// Token: 0x06003BE7 RID: 15335 RVA: 0x0016229C File Offset: 0x0016049C
	public void av(c1a A_0, cyt A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && !string.IsNullOrEmpty(serviceOrThrow.aqu().v().Name))
		{
			serviceOrThrow.aqu().r()["PlayerNameCaps"] = serviceOrThrow.aqu().v().Name.ToUpperInvariant();
		}
		aud aud = A_0.n("fo1");
		if (aud != null)
		{
			List<string> list = new List<string>
			{
				"wrk2",
				"scavle2",
				"hu_f1",
				"wrkmn1",
				"fow2",
				"rg_f2",
				"drifter"
			};
			List<csd> list2 = new List<csd>();
			csd csd = A_0.g("audience1");
			csd item = A_0.g("audience2");
			csd item2 = A_0.g("audience3");
			csd item3 = A_0.g("audience4");
			csd item4 = A_0.g("audience5");
			csd item5 = A_0.g("audience6");
			csd item6 = A_0.g("audience7");
			csd item7 = A_0.g("audience8");
			csd csd2 = A_0.g("guard_celeb1");
			csd csd3 = A_0.g("guard_celeb2");
			list2.Add(item);
			list2.Add(item2);
			list2.Add(item3);
			list2.Add(item4);
			list2.Add(item5);
			list2.Add(item6);
			list2.Add(item7);
			if (csd2 != null)
			{
				c5x c5x = vq.a("creatures\\generichumans\\foundrygunner", csd2, false);
				if (c5x != null && c5x.t.b != null)
				{
					c5x.t.b.y6()[ddq.ay] = new bt4("guard_celeb1");
					this.a(c5x);
				}
			}
			if (csd3 != null)
			{
				c5x c5x2 = vq.a("creatures\\generichumans\\foundrygunner", csd3, false);
				if (c5x2 != null && c5x2.t.b != null)
				{
					c5x2.t.b.y6()[ddq.ay] = new bt4("guard_celeb2");
					this.a(c5x2);
				}
			}
			if (csd != null)
			{
				c5x c5x3 = vq.a("creatures\\generichumans\\commoner", csd, false);
				if (c5x3 != null && c5x3.h.b != null)
				{
					c5x3.h.b.aa().Id = "thecrowd";
					c5x3.h.b.aa().Name = "Толпа";
				}
				bn5 aspect = new bn5(c5x3);
				c5x3.SetAspect<j7>(aspect);
				this.a(c5x3);
			}
			for (int i = 0; i < list.Count; i++)
			{
				c5x c5x4 = vq.a("creatures\\generichumans\\commoner", list2[i], false);
				if (c5x4 != null)
				{
					c5x4.h.b.a(list[i]);
					this.a(c5x4);
				}
			}
			c5x c5x5 = new ar7(new Guid("637d8965-6e63-4dfa-9ffc-8c4cc8f8dfd7"), aud).ao() as c5x;
			if (c5x5 != null)
			{
				a0l.a(c5x5, "move_preacher", true);
			}
			c5x c5x6 = new ar7(new Guid("23dd390c-302b-412a-84af-26146e7892ad"), aud).ao() as c5x;
			if (c5x6 != null)
			{
				a0l.a(c5x6, "move_commoner", true);
			}
			c5x c5x7 = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x7 != null)
			{
				c5x c5x8 = new ar7(new Guid("5fbe9675-82e6-4945-b6a1-6f059f986f2a"), aud).ao() as c5x;
				c5x7.VisualDirection = HorizontalDirection.East;
				if (c5x8 != null)
				{
					c5x7.GetAspect<j7>().a(c5x8.GetAspect<j7>(), false, null, false);
				}
			}
		}
	}

	// Token: 0x06003BE8 RID: 15336 RVA: 0x0016267C File Offset: 0x0016087C
	private void a(c5x A_0)
	{
		A_0.SetAspect<e3l>(new e3l(A_0)
		{
			a = 
			{
				"crowd"
			}
		});
	}
}
