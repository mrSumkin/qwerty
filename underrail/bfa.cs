using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Common.Settings;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001248 RID: 4680
[eiz("DTSN")]
[Serializable]
public sealed class bfa : c3r, ISerializable
{
	// Token: 0x06006519 RID: 25881 RVA: 0x002B2C14 File Offset: 0x002B0E14
	private bfa(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (csk)A_0.GetValue("DTSN:D", typeof(csk));
			this.b = A_0.GetBoolean("DTSN:CH");
			this.c = A_0.GetBoolean("DTSN:P");
			this.d = A_0.GetBoolean("DTSN:IP");
			return;
		}
		if (base.GetType() == typeof(bfa))
		{
			this.a = (csk)A_0.GetValue("_Damage", typeof(csk));
			this.b = A_0.GetBoolean("_CriticalHit");
			this.c = A_0.GetBoolean("_Periodic");
			this.d = A_0.GetBoolean("_IsPlayer");
			return;
		}
		this.a = (csk)A_0.GetValue("DamageTakenScrollingNotification+_Damage", typeof(csk));
		this.b = A_0.GetBoolean("DamageTakenScrollingNotification+_CriticalHit");
		this.c = A_0.GetBoolean("DamageTakenScrollingNotification+_Periodic");
		this.d = A_0.GetBoolean("DamageTakenScrollingNotification+_IsPlayer");
	}

	// Token: 0x0600651A RID: 25882 RVA: 0x002B2D48 File Offset: 0x002B0F48
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("DTSN:D", this.a);
		info.AddValue("DTSN:CH", this.b);
		info.AddValue("DTSN:P", this.c);
		info.AddValue("DTSN:IP", this.d);
	}

	// Token: 0x0600651B RID: 25883 RVA: 0x002B2DA0 File Offset: 0x002B0FA0
	public string sf()
	{
		if (this.a.DamageType != DamageType.Mechanical)
		{
			return "DamageType." + this.a.DamageType.ToString();
		}
		return null;
	}

	// Token: 0x0600651C RID: 25884 RVA: 0x002B2DE4 File Offset: 0x002B0FE4
	public string sg()
	{
		string text = "-" + this.a.Amount.ToString();
		if (this.b)
		{
			text += " Критический урон!";
		}
		return text;
	}

	// Token: 0x0600651D RID: 25885 RVA: 0x002B2E28 File Offset: 0x002B1028
	public Color sh()
	{
		if (!this.d)
		{
			return Color.Orange;
		}
		return Color.Red;
	}

	// Token: 0x0600651E RID: 25886 RVA: 0x002B2E40 File Offset: 0x002B1040
	public bool si()
	{
		return this.b;
	}

	// Token: 0x0600651F RID: 25887 RVA: 0x002B2E48 File Offset: 0x002B1048
	public ScrollingCombatTextOptions sj()
	{
		if (!this.c)
		{
			return ScrollingCombatTextOptions.Damage;
		}
		return ScrollingCombatTextOptions.PeriodicDamage;
	}

	// Token: 0x06006520 RID: 25888 RVA: 0x002B2E58 File Offset: 0x002B1058
	public bfa(csk A_0, bool A_1, bool A_2, bool A_3)
	{
		this.d = A_3;
		this.a = A_0;
		this.b = A_1;
		this.c = A_2;
	}

	// Token: 0x04002A38 RID: 10808
	private csk a;

	// Token: 0x04002A39 RID: 10809
	private bool b;

	// Token: 0x04002A3A RID: 10810
	private bool c;

	// Token: 0x04002A3B RID: 10811
	private bool d;
}
