using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000ABC RID: 2748
[eiz("XPBLASTPNSJ")]
[Serializable]
public sealed class ay6 : cze, ISerializable
{
	// Token: 0x06004020 RID: 16416 RVA: 0x0018578C File Offset: 0x0018398C
	private ay6(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004021 RID: 16417 RVA: 0x00185798 File Offset: 0x00183998
	public ay6()
	{
	}

	// Token: 0x06004022 RID: 16418 RVA: 0x001857A4 File Offset: 0x001839A4
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			string text = serviceOrThrow.aqu().r().GetClassPropertyValue<string>("npc_xpbl_as_todd_playerName");
			if (text != null)
			{
				if (text == "$(context.playerArenaTitle)")
				{
					text = serviceOrThrow.aqu().r().GetClassPropertyValue<string>("playerArenaTitle");
				}
				else if (text == "$(context.player.Name)")
				{
					text = serviceOrThrow.aqu().v().Name;
				}
				string value = text.ToUpperInvariant();
				string text2 = null;
				int? num = null;
				int num2 = 0;
				while (num2 < text.Length && num2 < 4 && !char.IsDigit(text[num2]))
				{
					if (char.IsLetter(text[num2]))
					{
						text2 = text[num2].ToString() + "-" + text[num2].ToString() + "-";
						num = new int?(num2);
						break;
					}
					num2++;
				}
				if (num != null && text2 != null)
				{
					value = text.Insert(num.Value, text2).ToUpperInvariant();
				}
				serviceOrThrow.aqu().r()["npc_xpbl_as_todd_playerName_stuttered"] = value;
			}
		}
	}
}
