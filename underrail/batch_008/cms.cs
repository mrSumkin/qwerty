using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Common.Settings;

// Token: 0x02001246 RID: 4678
[eiz("SGSN")]
[Serializable]
public sealed class cms : c3r, ISerializable
{
	// Token: 0x06006509 RID: 25865 RVA: 0x002B29E0 File Offset: 0x002B0BE0
	private cms(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetInt32("SGSN:A");
			this.b = A_0.GetBoolean("SGSN:CH");
			return;
		}
		if (base.GetType() == typeof(cms))
		{
			this.a = A_0.GetInt32("_Amount");
			this.b = A_0.GetBoolean("_CriticalHit");
			return;
		}
		this.a = A_0.GetInt32("ShieldGainedScrollingNotification+_Amount");
		this.b = A_0.GetBoolean("ShieldGainedScrollingNotification+_CriticalHit");
	}

	// Token: 0x0600650A RID: 25866 RVA: 0x002B2A80 File Offset: 0x002B0C80
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("SGSN:A", this.a);
		info.AddValue("SGSN:CH", this.b);
	}

	// Token: 0x0600650B RID: 25867 RVA: 0x002B2AA4 File Offset: 0x002B0CA4
	public string sf()
	{
		return "ShieldEmitters.0";
	}

	// Token: 0x0600650C RID: 25868 RVA: 0x002B2AAC File Offset: 0x002B0CAC
	public string sg()
	{
		return "+" + this.a.ToString();
	}

	// Token: 0x0600650D RID: 25869 RVA: 0x002B2AC4 File Offset: 0x002B0CC4
	public Color sh()
	{
		return adi.x;
	}

	// Token: 0x0600650E RID: 25870 RVA: 0x002B2ACC File Offset: 0x002B0CCC
	public bool si()
	{
		return this.b;
	}

	// Token: 0x0600650F RID: 25871 RVA: 0x002B2AD4 File Offset: 0x002B0CD4
	public ScrollingCombatTextOptions sj()
	{
		return ScrollingCombatTextOptions.ShieldGain;
	}

	// Token: 0x06006510 RID: 25872 RVA: 0x002B2AD8 File Offset: 0x002B0CD8
	public cms(int A_0, bool A_1)
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x04002A35 RID: 10805
	private int a;

	// Token: 0x04002A36 RID: 10806
	private bool b;
}
