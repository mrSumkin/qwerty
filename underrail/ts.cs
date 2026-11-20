using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001BF5 RID: 7157
public static class ts
{
	// Token: 0x06009BDE RID: 39902 RVA: 0x003D1E9C File Offset: 0x003D009C
	static ts()
	{
		ts.a[CharacterImmunities.None] = "Nothing";
		ts.a[CharacterImmunities.MindAffecting] = "атакам воздействующим на разум";
		ts.a[CharacterImmunities.Placeholder] = "Unknown";
		ts.a[CharacterImmunities.Stun] = "оглушению и дезориентации";
		ts.a[CharacterImmunities.Incapacitation] = "ошеломлению";
		ts.a[CharacterImmunities.Blind] = "ослеплению";
		ts.a[CharacterImmunities.MindControl] = "управлению разумом";
		ts.a[CharacterImmunities.Chill] = "переохлаждению";
		ts.a[CharacterImmunities.Freeze] = "заморозке";
		ts.a[CharacterImmunities.Slow] = "замедлению";
		ts.a[CharacterImmunities.Root] = "обездвиживанию";
		ts.a[CharacterImmunities.CriticalHits] = "критическим ударам";
		ts.a[CharacterImmunities.Bleeding] = "кровотечению";
		ts.a[CharacterImmunities.Fear] = "страху";
		ts.a[CharacterImmunities.Burning] = "горению";
		ts.a[CharacterImmunities.Poison] = "яду";
		ts.a[CharacterImmunities.ShortCircuiting] = "короткому замыканию";
		ts.a[CharacterImmunities.Dismantle] = "разборке";
		ts.a[CharacterImmunities.Caltrops] = "колючкам";
		ts.a[CharacterImmunities.AcidPuddles] = "кислотным лужам";
		ts.a[CharacterImmunities.Unbalancing] = "неустойчивости";
		ts.a[CharacterImmunities.Decapitation] = "обезглавливанию";
		ts.a[CharacterImmunities.Bilocation] = "билокации";
		ts.a[CharacterImmunities.AiScrambling] = "скремблированию ИИ";
		ts.a[CharacterImmunities.DirtyKickExtraStun] = "доп. оглушению от грязного удара";
		ts.a[CharacterImmunities.KneecapShot] = "Kneecap Shot";
	}

	// Token: 0x06009BDF RID: 39903 RVA: 0x003D20B8 File Offset: 0x003D02B8
	public static string a(CharacterImmunities A_0)
	{
		List<string> list = new List<string>();
		if (A_0 != CharacterImmunities.None)
		{
			foreach (object obj in Enum.GetValues(typeof(CharacterImmunities)))
			{
				CharacterImmunities characterImmunities = (CharacterImmunities)obj;
				if (characterImmunities != CharacterImmunities.None && (A_0 & characterImmunities) == characterImmunities)
				{
					string text = dh9.c("CharacterImmunities_DisplayText_" + characterImmunities.ToString());
					if (string.IsNullOrEmpty(text))
					{
						ts.a.TryGetValue(characterImmunities, out text);
					}
					if (!string.IsNullOrEmpty(text))
					{
						list.Add(text.ToLowerInvariant());
					}
				}
			}
		}
		if (list.Count == 0)
		{
			return dh9.c("NothingL");
		}
		return dh9.a(list);
	}

	// Token: 0x04003BC1 RID: 15297
	public static readonly Dictionary<CharacterImmunities, string> a = new Dictionary<CharacterImmunities, string>();
}
