using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x0200096D RID: 2413
[eiz("DCTATK")]
[Serializable]
public sealed class eb3 : bdw, ISerializable
{
	// Token: 0x06003AAE RID: 15022 RVA: 0x0015BDD8 File Offset: 0x00159FD8
	private eb3(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003AAF RID: 15023 RVA: 0x0015BDE0 File Offset: 0x00159FE0
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003AB0 RID: 15024 RVA: 0x0015BDE4 File Offset: 0x00159FE4
	public eb3()
	{
	}

	// Token: 0x06003AB1 RID: 15025 RVA: 0x0015BDF0 File Offset: 0x00159FF0
	public void av(c1a A_0, cyt A_1)
	{
		if (A_1 != null)
		{
			bool value = A_1.r().GetPrimitivePropertyValue<bool>("npc_tch_stavros_died", new bool?(false)).Value;
			if (A_0 != null)
			{
				aud aud = A_0.n("dc-tch");
				if (aud != null)
				{
					if (value)
					{
						foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
						{
							c5x c5x = (c5x)b0b;
							if (c5x.h.b != null && c5x.h.b.aa().FactionId == asp.e4 && !c5x.h.b.aa().Dead)
							{
								c5x.h.b.aa().a(null, null, false);
							}
						}
						doq a_ = doq.a(Path.Combine(d5x.q(), "dc-tch_l2") + ".uzl");
						aud.Zone.a(a_, 1, null);
						c5x item = new ar7(new Guid("3aef1178-636b-46f6-9501-fa07fd30cfdb"), aud).ao() as c5x;
						c5x item2 = new ar7(new Guid("e05e7546-2b32-4850-bf5c-d9b7609b1c6b"), aud).ao() as c5x;
						c5x item3 = new ar7(new Guid("603c4cd3-e32f-4f12-922a-a8968c6d0c95"), aud).ao() as c5x;
						c5x item4 = new ar7(new Guid("1d59ac59-fc07-4c7b-9a77-4dc7e1a45678"), aud).ao() as c5x;
						c5x item5 = new ar7(new Guid("35f0d6b7-616e-4657-a357-24bc6a1cd341"), aud).ao() as c5x;
						c5x item6 = new ar7(new Guid("e6962e10-b108-48f0-84ff-e92f47abfbf9"), aud).ao() as c5x;
						List<b0b> list = new List<b0b>();
						list.Add(item);
						list.Add(item2);
						list.Add(item3);
						list.Add(item4);
						list.Add(item5);
						list.Add(item6);
						if (list == null)
						{
							return;
						}
						using (List<b0b>.Enumerator enumerator = list.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								b0b b0b2 = enumerator.Current;
								cnb cnb = ((c5x)b0b2).s.b as cnb;
								if (cnb != null)
								{
									cnb.d(true);
								}
							}
							return;
						}
					}
					foreach (b0b b0b3 in Enumerable.ToList<b0b>(aud.Entities))
					{
						c5x c5x2 = (c5x)b0b3;
						if (c5x2.h.b != null && c5x2.h.b.aa().FactionId == asp.e4 && !c5x2.h.b.aa().Dead)
						{
							c5x2.an();
							c5x2.w();
						}
					}
				}
			}
		}
	}
}
