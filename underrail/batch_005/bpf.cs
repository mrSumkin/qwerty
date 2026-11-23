using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Common.Settings;

// Token: 0x02001247 RID: 4679
[eiz("SEASN")]
[Serializable]
public sealed class bpf : c3r, ISerializable
{
	// Token: 0x06006511 RID: 25873 RVA: 0x002B2AF4 File Offset: 0x002B0CF4
	private bpf(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (els)A_0.GetValue("SEASN:SE", typeof(els));
			return;
		}
		if (base.GetType() == typeof(bpf))
		{
			this.a = (els)A_0.GetValue("_StatusEffect", typeof(els));
			return;
		}
		this.a = (els)A_0.GetValue("StatusEffectAppliedScrollingNotification+_StatusEffect", typeof(els));
	}

	// Token: 0x06006512 RID: 25874 RVA: 0x002B2B90 File Offset: 0x002B0D90
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("SEASN:SE", this.a);
	}

	// Token: 0x06006513 RID: 25875 RVA: 0x002B2BA4 File Offset: 0x002B0DA4
	public string sf()
	{
		return this.a.Icon;
	}

	// Token: 0x06006514 RID: 25876 RVA: 0x002B2BB4 File Offset: 0x002B0DB4
	public string sg()
	{
		return this.a.Name;
	}

	// Token: 0x06006515 RID: 25877 RVA: 0x002B2BC4 File Offset: 0x002B0DC4
	public Color sh()
	{
		return adi.ai[this.a.Nature];
	}

	// Token: 0x06006516 RID: 25878 RVA: 0x002B2BDC File Offset: 0x002B0DDC
	public bool si()
	{
		return false;
	}

	// Token: 0x06006517 RID: 25879 RVA: 0x002B2BE0 File Offset: 0x002B0DE0
	public ScrollingCombatTextOptions sj()
	{
		if (this.a.Nature != ci8.c)
		{
			return ScrollingCombatTextOptions.Buffs;
		}
		return ScrollingCombatTextOptions.Debuffs;
	}

	// Token: 0x06006518 RID: 25880 RVA: 0x002B2C00 File Offset: 0x002B0E00
	public bpf(els A_0)
	{
		this.a = A_0;
	}

	// Token: 0x04002A37 RID: 10807
	private els a;
}
