using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Common.Settings;

// Token: 0x02001232 RID: 4658
[eiz("APCO")]
[Serializable]
public sealed class cmq : c3r, ISerializable
{
	// Token: 0x06006466 RID: 25702 RVA: 0x002B1B30 File Offset: 0x002AFD30
	private cmq(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetInt32("APCO:A");
	}

	// Token: 0x06006467 RID: 25703 RVA: 0x002B1B4C File Offset: 0x002AFD4C
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("APCO:A", this.a);
	}

	// Token: 0x06006468 RID: 25704 RVA: 0x002B1B60 File Offset: 0x002AFD60
	public string sf()
	{
		return "Abilities.106";
	}

	// Token: 0x06006469 RID: 25705 RVA: 0x002B1B68 File Offset: 0x002AFD68
	public string sg()
	{
		if (this.a > 1)
		{
			return string.Format("Сохранено очков действия: {0}", this.a);
		}
		return string.Format("Сохранено очков действия: {0}", this.a);
	}

	// Token: 0x0600646A RID: 25706 RVA: 0x002B1BA4 File Offset: 0x002AFDA4
	public Color sh()
	{
		return new Color(100, 255, 100);
	}

	// Token: 0x0600646B RID: 25707 RVA: 0x002B1BB4 File Offset: 0x002AFDB4
	public bool si()
	{
		return false;
	}

	// Token: 0x0600646C RID: 25708 RVA: 0x002B1BB8 File Offset: 0x002AFDB8
	public ScrollingCombatTextOptions sj()
	{
		return ScrollingCombatTextOptions.ApCarryover;
	}

	// Token: 0x0600646D RID: 25709 RVA: 0x002B1BC0 File Offset: 0x002AFDC0
	public cmq(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x04002A11 RID: 10769
	public int a;
}
