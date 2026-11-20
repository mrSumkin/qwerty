using System;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001472 RID: 5234
[eiz("USBBA")]
[Serializable]
public sealed class ae : a6k, ISerializable
{
	// Token: 0x0600762C RID: 30252 RVA: 0x0031EC34 File Offset: 0x0031CE34
	private ae(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600762D RID: 30253 RVA: 0x0031EC40 File Offset: 0x0031CE40
	public ae()
	{
	}

	// Token: 0x0600762E RID: 30254 RVA: 0x0031EC4C File Offset: 0x0031CE4C
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.vg().q() == null || base.vg().q().h.b == null)
		{
			return dc4.e;
		}
		if (ae.a(base.vg().q().h.b))
		{
			return dc4.c;
		}
		return dc4.e;
	}

	// Token: 0x0600762F RID: 30255 RVA: 0x0031ECA8 File Offset: 0x0031CEA8
	private static string b(string A_0)
	{
		string[] array = new string[]
		{
			"А-А-А-АААА!",
			"Огонь в дыре!",
			"БУ-У-У-У-УМ!"
		};
		string[] array2 = new string[]
		{
			"Гооооооори!",
			"Гори, детка!",
			"Время шашлыка!",
			"ХА-ХА-ХА-ХА-ХА!"
		};
		string[] array3 = new string[]
		{
			"Пора спать!",
			"Спокойной ночи!",
			"Стой на месте!"
		};
		string[] array4 = new string[]
		{
			"Руби провода!",
			"Гаси свет!"
		};
		string[] array5 = new string[]
		{
			"Сделай глубокий вдох!",
			"Наполни свои лёгкие!"
		};
		if (A_0 != null)
		{
			if (A_0 == "explosive")
			{
				return array[cuo.a.Next(array.Length)];
			}
			if (A_0 == "incendiary")
			{
				return array2[cuo.a.Next(array2.Length)];
			}
			if (A_0 == "incapacitation")
			{
				return array3[cuo.a.Next(array3.Length)];
			}
			if (A_0 == "emp")
			{
				return array4[cuo.a.Next(array4.Length)];
			}
			if (A_0 == "gas")
			{
				return array5[cuo.a.Next(array5.Length)];
			}
		}
		return array[cuo.a.Next(array.Length)];
	}

	// Token: 0x06007630 RID: 30256 RVA: 0x0031EE20 File Offset: 0x0031D020
	public static bool a(amc A_0)
	{
		bool result = false;
		string a_ = null;
		ItemSlot<coh>[] array = A_0.aa().Gear.d();
		for (int i = 0; i < array.Length; i++)
		{
			coh coh = array[i].pp();
			if (coh != null && coh.Definition is dxw && coh.Definition.a2().Count > 0)
			{
				c3n c3n = dgk.a(coh.Definition.a2()[0].CapabilityFullTypeName);
				if (c3n != null)
				{
					ak1 ak = A_0.a8().Area.a(A_0.a8().aj().a());
					if (ak == null)
					{
						return false;
					}
					b2s b2s = cp.a(ecf.a(c3n, new eru(new EntityAspectReference<amc, amc>(A_0)), coh) as eu7, A_0.a8(), ak) as b2s;
					if (b2s != null)
					{
						result = true;
						ae.RemoveInvocationPart<dre>(b2s);
						ae.RemoveInvocationPart<aq8>(b2s);
						ae.RemoveInvocationPart<anw>(b2s);
						ae.RemoveInvocationPart<ch8>(b2s);
						ae.RemoveInvocationPart<e4t>(b2s);
						ae.RemoveInvocationPart<aro>(b2s);
						ae.RemoveInvocationPart<e4t>(b2s);
						ae.RemoveInvocationPart<a4s>(b2s);
						ae.RemoveInvocationPart<dea>(b2s);
						A_0.a8().Zone.ActionManager.g9(b2s, atp.a);
						a_ = ae.a(coh.Definition.a5());
					}
				}
			}
		}
		c0s aspect = A_0.a8().GetAspect<c0s>();
		if (aspect != null)
		{
			aspect.a(ae.b(a_), true, new Color?(Color.Red), null);
		}
		return result;
	}

	// Token: 0x06007631 RID: 30257 RVA: 0x0031EFBC File Offset: 0x0031D1BC
	private static void RemoveInvocationPart<T>(b2s actionSequence)
	{
		for (;;)
		{
			auv auv = Enumerable.FirstOrDefault<auv>(Enumerable.Where<auv>(actionSequence.ad(), new Func<auv, bool>(ae.<>c__5<T>.a.a)));
			if (auv == null)
			{
				break;
			}
			actionSequence.ad().Remove(auv);
		}
	}

	// Token: 0x06007632 RID: 30258 RVA: 0x0031F014 File Offset: 0x0031D214
	private static string a(string A_0)
	{
		if (A_0 != null)
		{
			if (A_0.Contains("empGrande"))
			{
				return "emp";
			}
			if (A_0.Contains("chemhazeGrenade") || A_0.Contains("GasGrenade") || A_0.Contains("BiocideGrenade"))
			{
				return "gas";
			}
			if (A_0.Contains("molotovCocktail") || A_0.Contains("magnesiumGrenade") || A_0.Contains("napalmGrenade"))
			{
				return "incendiary";
			}
			if (A_0.Contains("stingballGrenade") || A_0.Contains("flashbang"))
			{
				return "incapacitation";
			}
		}
		return "explosive";
	}
}
