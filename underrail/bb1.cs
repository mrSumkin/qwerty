using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Items;

// Token: 0x020008F6 RID: 2294
[eiz("CCGAUNT1")]
[Serializable]
public sealed class bb1 : bdw, ISerializable
{
	// Token: 0x060038C7 RID: 14535 RVA: 0x00150B24 File Offset: 0x0014ED24
	private bb1(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060038C8 RID: 14536 RVA: 0x00150B2C File Offset: 0x0014ED2C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x060038C9 RID: 14537 RVA: 0x00150B30 File Offset: 0x0014ED30
	public bb1()
	{
	}

	// Token: 0x060038CA RID: 14538 RVA: 0x00150B3C File Offset: 0x0014ED3C
	public void av(c1a A_0, cyt A_1)
	{
		int num = dkr.f();
		if (A_0 != null)
		{
			aud aud = Enumerable.FirstOrDefault<aud>(A_0.Areas);
			if (aud != null)
			{
				dkr.a(aud, new string[]
				{
					"a378ff15-7440-4de6-a8ef-df6027186e80"
				});
				if (num > 0)
				{
					csd csd = A_0.g("extraRat1");
					bool flag = A_0.g("extraRat2") != null;
					csd csd2 = A_0.g("extraRat3");
					if (csd != null)
					{
						vq.a("creatures\\rathound", csd, false);
					}
					if (flag)
					{
						vq.a("creatures\\rathound", csd, false);
					}
					if (csd2 != null)
					{
						vq.a("creatures\\rathound", csd, false);
					}
				}
				if (num > 1)
				{
					csd csd3 = A_0.g("extraRat4");
					csd csd4 = A_0.g("extraRat5");
					csd csd5 = A_0.g("extraRat6");
					if (csd3 != null)
					{
						vq.a("creatures\\rathoundAlpha", csd3, false);
					}
					if (csd4 != null)
					{
						vq.a("creatures\\rathoundAlpha", csd4, false);
					}
					if (csd5 != null)
					{
						vq.a("creatures\\rathoundAlpha", csd5, false);
					}
				}
				if (num > 2)
				{
					csd csd6 = A_0.g("extraRat4");
					csd csd7 = A_0.g("extraRat5");
					csd csd8 = A_0.g("extraRat6");
					if (csd6 != null)
					{
						vq.a("creatures\\rathoundAncient", csd6, false);
					}
					if (csd7 != null)
					{
						vq.a("creatures\\rathoundAlpha", csd7, false);
					}
					if (csd8 != null)
					{
						vq.a("creatures\\rathoundAlpha", csd8, false);
					}
				}
				d02 serviceOrThrow = bpo.GetServiceOrThrow<d02>();
				List<amc> list = new List<amc>();
				foreach (d4n d4n in serviceOrThrow.ahl())
				{
					if (d4n.b.aa().FactionId == asp.av)
					{
						if (d4n.b.a8().Location.X > 7f || d4n.b.a8().Location.Y > 5f)
						{
							list.Add(d4n.b);
						}
						d4n.b.a8().RemoveAspect<a6p>();
					}
				}
				if (list.Count > 0)
				{
					amc amc = list[cuo.a.Next(list.Count)];
					d48 d = new d48(new LibraryItemDefinitionProvider<a0z>("plot\\GauntletRathoundRoomKey"));
					d.Stealable = false;
					d.Lootable = true;
					amc.aa().Bag.z3(d, true);
				}
			}
		}
	}
}
