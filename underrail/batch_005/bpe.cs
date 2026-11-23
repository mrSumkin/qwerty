using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules;

// Token: 0x0200090F RID: 2319
[eiz("CCGBR")]
[Serializable]
public sealed class bpe : bdw, ISerializable
{
	// Token: 0x0600392B RID: 14635 RVA: 0x00152848 File Offset: 0x00150A48
	private bpe(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x0600392C RID: 14636 RVA: 0x00152850 File Offset: 0x00150A50
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x0600392D RID: 14637 RVA: 0x00152854 File Offset: 0x00150A54
	public bpe()
	{
	}

	// Token: 0x0600392E RID: 14638 RVA: 0x0015285C File Offset: 0x00150A5C
	public void av(c1a A_0, cyt A_1)
	{
		if (A_1 != null && A_0 != null)
		{
			aud aud = A_0.n("cc_abandoned");
			if (aud != null)
			{
				bool value = A_1.r().GetPrimitivePropertyValue<bool>("quest_cc_retakeOutpostForGorsky_tidyUp", new bool?(false)).Value;
				int value2 = A_1.r().GetPrimitivePropertyValue<int>("quest_cc_retakeOutpostForGorsky_crawlersKilled", new int?(0)).Value;
				TimeSpan? primitivePropertyValue = A_1.r().GetPrimitivePropertyValue<TimeSpan>("quest_cc_retakeOutpostForGorsky_tidyingTime", null);
				bool value3 = A_1.r().GetPrimitivePropertyValue<bool>("quest_cc_retakeOutpostForGorsky_finished", new bool?(false)).Value;
				bool value4 = A_1.r().GetPrimitivePropertyValue<bool>("npc_gorsky_died", new bool?(false)).Value;
				bool value5 = A_1.r().GetPrimitivePropertyValue<bool>("npc_cc_sneaky_died", new bool?(false)).Value;
				int value6 = A_1.r().GetPrimitivePropertyValue<bool>("npc_fo_dan_died", new bool?(false)).Value ? 1 : 0;
				bool value7 = A_1.r().GetPrimitivePropertyValue<bool>("npc_fo_dan_helpGorskyInCC", new bool?(false)).Value;
				int num = 8;
				if (A_1.ae() == GameDifficulty.Easy)
				{
					num = 6;
				}
				else if (A_1.ae() == GameDifficulty.Hard)
				{
					num = 10;
				}
				else if (A_1.ae() == GameDifficulty.Dominating)
				{
					num = 11;
				}
				bool flag = value6 == 0 && value7;
				if (value3 && !value && primitivePropertyValue != null && (!value4 || !value5 || flag) && primitivePropertyValue.Value <= A_1.p() && value2 >= num)
				{
					foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
					{
						c5x c5x = (c5x)b0b;
						if (!string.IsNullOrEmpty(c5x.y8()) && c5x.h.b == null && c5x.s.b is c7j && (c5x.y8().EndsWith("- тело") || c5x.y8() == "Останки"))
						{
							c5x.w();
							c5x.an();
						}
						else if (c5x.o.b != null && c5x.o.b.a == "Effects\\BloodPool")
						{
							c5x.w();
							c5x.an();
						}
						else if (c5x != null && c5x.GetAspect<a3f>() != null && c5x.GetAspect<a3f>().a().GetPrimitivePropertyValue<bool>("IsCorpse", new bool?(false)).Value)
						{
							c5x.an();
							c5x.w();
						}
					}
					c5x c5x2 = new ar7(new Guid("94e5185a-506d-41ca-87c8-8595e7cd28fb"), aud).ao() as c5x;
					c5x c5x3 = new ar7(new Guid("4a06e8fb-c9d2-4c18-afad-6e92118ef334"), aud).ao() as c5x;
					c5x c5x4 = new ar7(new Guid("e19114c9-2185-47b5-812b-7e45863ac33f"), aud).ao() as c5x;
					c5x c5x5 = new ar7(new Guid("5b6e2069-f7a5-4ce0-92a0-3fac8085f6be"), aud).ao() as c5x;
					c5x c5x6 = new ar7(new Guid("31658b0a-550d-4ae3-b11e-395c8158951d"), aud).ao() as c5x;
					if (c5x2 != null)
					{
						c5x2.t.b.y6()[ddq.ay] = new bt4("global:gorsky:tidy");
					}
					if (c5x3 != null)
					{
						c5x3.t.b.y6()[ddq.ay] = new bt4("global:cc_sneaky:tidy");
					}
					if (c5x4 != null)
					{
						c5x4.t.b.y6()[ddq.ay] = new bt4("global:cc_mykola:tidy");
					}
					if (c5x5 != null)
					{
						c5x5.t.b.y6()[ddq.ay] = new bt4("global:fo_dan:tidy");
					}
					if (c5x6 != null)
					{
						c5x6.Location = new Vector3(3f, 8f, 0f);
						c5x6.Size = new Vector3(c5x6.Size.X, c5x6.Size.Y - 1f, c5x6.Size.Z);
						c5x6.ah();
						if (c5x6.q.b != null)
						{
							c5x6.q.b.b("st1");
							c5x6.q.b.b(0);
						}
					}
					doq a_ = doq.a(Path.Combine(d5x.q(), "cc_abandoned_l3") + ".uzl");
					A_0.a(a_, 1, null);
					A_1.r()["quest_cc_retakeOutpostForGorsky_tidyUp"] = true;
				}
			}
		}
	}
}
