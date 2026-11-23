using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;

// Token: 0x02000661 RID: 1633
[eiz("G35")]
[Serializable]
public sealed class bhb : ISerializable
{
	// Token: 0x0600297B RID: 10619 RVA: 0x000EC240 File Offset: 0x000EA440
	private bhb(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetString("G35:L");
		this.b = A_0.GetString("G35:A");
		this.c = (Vector3)A_0.GetValue("G35:V", typeof(Vector3));
		this.d = (HorizontalDirection)A_0.GetValue("G35:D", typeof(HorizontalDirection));
	}

	// Token: 0x0600297C RID: 10620 RVA: 0x000EC2B8 File Offset: 0x000EA4B8
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("G35:L", this.a);
		info.AddValue("G35:A", this.b);
		info.AddValue("G35:V", this.c);
		info.AddValue("G35:D", this.d);
	}

	// Token: 0x0600297D RID: 10621 RVA: 0x000EC314 File Offset: 0x000EA514
	public bhb()
	{
	}

	// Token: 0x0600297E RID: 10622 RVA: 0x000EC31C File Offset: 0x000EA51C
	public bhb(string A_0, string A_1, Vector3 A_2, HorizontalDirection A_3)
	{
		this.a = A_0;
		this.b = A_1;
		this.c = A_2;
		this.d = A_3;
	}

	// Token: 0x0400169E RID: 5790
	public string a;

	// Token: 0x0400169F RID: 5791
	public string b;

	// Token: 0x040016A0 RID: 5792
	public Vector3 c;

	// Token: 0x040016A1 RID: 5793
	public HorizontalDirection d;
}
