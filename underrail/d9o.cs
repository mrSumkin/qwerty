using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02000A5A RID: 2650
[eiz("LSCOUJ")]
[Serializable]
public sealed class d9o : cze, ISerializable
{
	// Token: 0x06003EA3 RID: 16035 RVA: 0x0017A418 File Offset: 0x00178618
	private d9o(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003EA4 RID: 16036 RVA: 0x0017A424 File Offset: 0x00178624
	public d9o()
	{
	}

	// Token: 0x06003EA5 RID: 16037 RVA: 0x0017A430 File Offset: 0x00178630
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null && c5x.h.b != null)
		{
			string text = c5x.h.b.aa().CustomProperties.GetClassPropertyValue<string>(ddm.j);
			if (text == null)
			{
				int num = c5x.h.b.am().LastIndexOf("_");
				if (num == 4 || num == -1)
				{
					text = c5x.h.b.am();
				}
				else
				{
					text = c5x.h.b.am().Substring(0, num);
				}
				c5x.h.b.aa().CustomProperties[ddm.j] = text;
			}
			string classPropertyValue = c5x.h.b.aa().CustomProperties.GetClassPropertyValue<string>(ddm.i);
			string text2 = text;
			if (!string.IsNullOrEmpty(classPropertyValue))
			{
				text2 = text2 + "_" + classPropertyValue;
			}
			if (c5x.h.b.am() != text2)
			{
				c5x.h.b.a(text2);
			}
			aru aru = c5x.c();
			HashSet<string> hashSet = new HashSet<string>();
			if (!string.IsNullOrEmpty(classPropertyValue))
			{
				c5x.h.b.aa().Offense.a(WeaponKey.Secondary);
				string text3 = "carriedObject_" + classPropertyValue;
				lh lh = ckw.a(classPropertyValue);
				if (lh == null)
				{
					goto IL_2EF;
				}
				if (c5x.h.b.aa().Offense.u().TypedDefinition.az() != text3)
				{
					cd1 cd = lh.akd(c5x.h.b.aa());
					if (cd != null)
					{
						cd.TypedDefinition.g(text3);
						cd.Lootable = false;
						cd.Stealable = false;
						c5x.h.b.aa().Gear.j()[WeaponKey.Secondary].a(cd, true);
					}
				}
				Dictionary<string, app> dictionary = lh.mi(c5x.h.b);
				if (dictionary == null || dictionary.Count <= 0)
				{
					goto IL_2EF;
				}
				using (Dictionary<string, app>.Enumerator enumerator = dictionary.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						KeyValuePair<string, app> keyValuePair = enumerator.Current;
						string text4 = string.Format("carObj_{0}_{1}", classPropertyValue, keyValuePair.Key);
						hashSet.Add(text4);
						if (!aru.e().ContainsKey(text4))
						{
							aru.a(text4, keyValuePair.Value.a(), keyValuePair.Value.b(), keyValuePair.Value.d(), keyValuePair.Value.f(), false);
						}
					}
					goto IL_2EF;
				}
			}
			c5x.h.b.aa().Offense.a(WeaponKey.Primary);
			IL_2EF:
			HashSet<string> hashSet2 = new HashSet<string>();
			if (aru.e().Count > 0)
			{
				foreach (KeyValuePair<string, app> keyValuePair2 in aru.e())
				{
					if (!hashSet.Contains(keyValuePair2.Key) && keyValuePair2.Key.StartsWith("carObj_"))
					{
						hashSet2.Add(keyValuePair2.Key);
					}
				}
			}
			if (hashSet2.Count > 0)
			{
				foreach (string a_ in hashSet2)
				{
					aru.a(a_, false);
				}
			}
		}
	}
}
