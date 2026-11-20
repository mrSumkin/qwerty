using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Comm;

// Token: 0x02000FBB RID: 4027
[eiz("CSEC")]
[Serializable]
public sealed class d3o : dnh, ISerializable
{
	// Token: 0x06005289 RID: 21129 RVA: 0x0024E0AC File Offset: 0x0024C2AC
	private d3o(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = (CombatSpeakEvent)A_0.GetValue("CSEC:E", typeof(CombatSpeakEvent));
		this.a = A_0.GetInt32("CSEC:P");
	}

	// Token: 0x0600528A RID: 21130 RVA: 0x0024E0E8 File Offset: 0x0024C2E8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CSEC:E", this.b);
		info.AddValue("CSEC:P", this.a);
	}

	// Token: 0x0600528B RID: 21131 RVA: 0x0024E11C File Offset: 0x0024C31C
	public int b()
	{
		return this.a;
	}

	// Token: 0x0600528C RID: 21132 RVA: 0x0024E124 File Offset: 0x0024C324
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600528D RID: 21133 RVA: 0x0024E130 File Offset: 0x0024C330
	public CombatSpeakEvent a()
	{
		return this.b;
	}

	// Token: 0x0600528E RID: 21134 RVA: 0x0024E138 File Offset: 0x0024C338
	public void a(CombatSpeakEvent A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600528F RID: 21135 RVA: 0x0024E144 File Offset: 0x0024C344
	public d3o()
	{
	}

	// Token: 0x06005290 RID: 21136 RVA: 0x0024E14C File Offset: 0x0024C34C
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		if (A_1 != null)
		{
			CombatSpeakEvent? primitivePropertyValue = A_1.GetPrimitivePropertyValue<CombatSpeakEvent>("combatSpeakEvent", null);
			CombatSpeakEvent combatSpeakEvent = this.b;
			return primitivePropertyValue.GetValueOrDefault() == combatSpeakEvent & primitivePropertyValue != null;
		}
		return false;
	}

	// Token: 0x06005291 RID: 21137 RVA: 0x0024E190 File Offset: 0x0024C390
	public override string ToString()
	{
		string text = this.b.ToString();
		if (this.a != 0)
		{
			text += string.Format(" {0}", this.a);
		}
		return text;
	}

	// Token: 0x040021CF RID: 8655
	private int a;

	// Token: 0x040021D0 RID: 8656
	private CombatSpeakEvent b;
}
