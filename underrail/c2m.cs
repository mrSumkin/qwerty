using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B0D RID: 2829
[eiz("XPBLMCRV")]
[Serializable]
public sealed class c2m : cze, ISerializable
{
	// Token: 0x06004177 RID: 16759 RVA: 0x001911C8 File Offset: 0x0018F3C8
	private c2m(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004178 RID: 16760 RVA: 0x001911D4 File Offset: 0x0018F3D4
	public c2m()
	{
	}

	// Token: 0x06004179 RID: 16761 RVA: 0x001911DC File Offset: 0x0018F3DC
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		aud aud = null;
		if (A_0 != null)
		{
			aud = A_0.Area;
		}
		else if (A_1 != null)
		{
			aud = A_1.Area;
		}
		if (aud != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_mc_resolved", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_mc_acceptedDeath", new bool?(false)).Value)
			{
				TimeSpan? primitivePropertyValue = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<TimeSpan>("loc_xpbl_mc_nextVisionAfterResolution", null);
				Random random = new Random();
				if (primitivePropertyValue == null)
				{
					double value = (double)random.Next(20, 30);
					primitivePropertyValue = new TimeSpan?(serviceOrThrow.aqu().p() + TimeSpan.FromSeconds(4.0));
					serviceOrThrow.aqu().r()["loc_xpbl_mc_nextVisionAfterResolution"] = serviceOrThrow.aqu().p() + TimeSpan.FromSeconds(value);
				}
				if (primitivePropertyValue <= serviceOrThrow.aqu().p())
				{
					List<string> list = new List<string>
					{
						"::Вы слышите слабое всхлипывание...::",
						"::Запах гниения мгновенно ударяет вам в нос...::",
						"::За стенами слышны крики...::",
						"::Вы чувствуете лёгкую головную боль, но она проходит в одно мгновение...::",
						"::Ваше зрение на мгновение затуманивается...::",
						"::Тяжёлая боль наполняет ваш позвоночник...::",
						"::Тени пытаются захватить вас...::",
						"::Воздух слишком удушающий...::"
					};
					new cct(list[random.Next(0, list.Count)], true, null, bvl.d).ym(serviceOrThrow.aqu().v().b(), null, null);
					serviceOrThrow.aqu().r()["loc_xpbl_mc_nextVisionAfterResolution"] = serviceOrThrow.aqu().p() + TimeSpan.FromSeconds((double)random.Next(20, 30));
				}
			}
		}
	}
}
