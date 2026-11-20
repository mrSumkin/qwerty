using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Common.Settings;

// Token: 0x02001238 RID: 4664
[eiz("DBSN")]
[Serializable]
public sealed class emm : c3r, ISerializable
{
	// Token: 0x06006499 RID: 25753 RVA: 0x002B2054 File Offset: 0x002B0254
	private emm(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = (csk)A_0.GetValue("DBSN:D", typeof(csk));
		this.b = A_0.GetBoolean("DBSN:IP");
	}

	// Token: 0x0600649A RID: 25754 RVA: 0x002B2090 File Offset: 0x002B0290
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("DBSN:D", this.a);
		info.AddValue("DBSN:IP", this.b);
	}

	// Token: 0x0600649B RID: 25755 RVA: 0x002B20BC File Offset: 0x002B02BC
	public string sf()
	{
		return null;
	}

	// Token: 0x0600649C RID: 25756 RVA: 0x002B20C0 File Offset: 0x002B02C0
	public string sg()
	{
		return string.Format("Заблокировано! ({0})", this.a.Amount);
	}

	// Token: 0x0600649D RID: 25757 RVA: 0x002B20DC File Offset: 0x002B02DC
	public Color sh()
	{
		return Color.White;
	}

	// Token: 0x0600649E RID: 25758 RVA: 0x002B20E4 File Offset: 0x002B02E4
	public bool si()
	{
		return false;
	}

	// Token: 0x0600649F RID: 25759 RVA: 0x002B20E8 File Offset: 0x002B02E8
	public ScrollingCombatTextOptions sj()
	{
		return ScrollingCombatTextOptions.Damage;
	}

	// Token: 0x060064A0 RID: 25760 RVA: 0x002B20EC File Offset: 0x002B02EC
	public emm(csk A_0, bool A_1)
	{
		this.b = A_1;
		this.a = A_0;
	}

	// Token: 0x04002A1B RID: 10779
	private csk a;

	// Token: 0x04002A1C RID: 10780
	private bool b;
}
