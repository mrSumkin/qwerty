using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000B59 RID: 2905
[eiz("JYPAFDJ")]
[Serializable]
public sealed class a02 : cze, ISerializable
{
	// Token: 0x06004295 RID: 17045 RVA: 0x0019D370 File Offset: 0x0019B570
	private a02(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004296 RID: 17046 RVA: 0x0019D37C File Offset: 0x0019B57C
	public a02()
	{
	}

	// Token: 0x06004297 RID: 17047 RVA: 0x0019D388 File Offset: 0x0019B588
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_0 != null)
		{
			aud aud = A_0.Area;
			if (aud != null && aud.Zone != null)
			{
				Dictionary<string, string[]> dictionary = new Dictionary<string, string[]>();
				dictionary["c6dcad2d-d681-4eb8-9ae0-746ea36c0b18"] = new string[]
				{
					"88f5e9b0-80fa-4ed7-968f-d36b05744c6f",
					"6b3d34c2-22fb-47f0-aa79-3d1deb1467ee"
				};
				dictionary["56b4c576-33b5-410c-93a6-c940386eb768"] = new string[]
				{
					"e7b41656-6178-44b3-becd-498c3c139cac",
					"6eabb871-b4e1-4658-825d-293af3c52a1b"
				};
				dictionary["c1af396b-738c-4403-bd82-6515ae2006cf"] = new string[]
				{
					"f230bbcd-c7a5-49a4-8697-e142176f485d",
					"e3adf47e-c9df-411a-9406-bcca93747b93"
				};
				foreach (KeyValuePair<string, string[]> keyValuePair in dictionary)
				{
					c5x c5x = null;
					string[] value = keyValuePair.Value;
					for (int i = 0; i < value.Length; i++)
					{
						c5x c5x2 = new ar7(new Guid(value[i]), aud).ao() as c5x;
						if (c5x2 != null && c5x2.h.b != null && c5x2.t.b != null)
						{
							if (c5x == null)
							{
								c5x = c5x2;
							}
							bt4 classPropertyValue = c5x2.t.b.y6().GetClassPropertyValue<bt4>(ddq.ay);
							if (classPropertyValue != null && classPropertyValue.d() && classPropertyValue.b().Length == 2)
							{
								classPropertyValue.a("b" + classPropertyValue.b().Substring(1));
							}
							c5x2.t.b.y6()[ddq.ac] = CharacterState.Attack1;
							c5x2.t.b.y6()[ddq.ad] = 0;
						}
					}
					if (c5x != null)
					{
						bim bim = new EntityAspectReference<bim, bim>(aud, new Guid(keyValuePair.Key)).ao();
						if (bim != null)
						{
							bim.a(c5x, null, false, false);
						}
					}
				}
			}
		}
	}
}
