using System;
using System.Runtime.Serialization;

// Token: 0x020011C0 RID: 4544
[eiz("C10")]
[Serializable]
public abstract class s0 : ISerializable
{
	// Token: 0x0600612A RID: 24874 RVA: 0x002A5E04 File Offset: 0x002A4004
	protected s0(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetInt32("C10:L");
	}

	// Token: 0x0600612B RID: 24875 RVA: 0x002A5E20 File Offset: 0x002A4020
	public virtual void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("C10:L", this.a);
	}

	// Token: 0x170001D1 RID: 465
	// (get) Token: 0x0600612C RID: 24876 RVA: 0x002A5E34 File Offset: 0x002A4034
	// (set) Token: 0x0600612D RID: 24877 RVA: 0x002A5E3C File Offset: 0x002A403C
	public int AccessLevel
	{
		get
		{
			return this.a;
		}
		set
		{
			this.a = value;
		}
	}

	// Token: 0x170001D2 RID: 466
	// (get) Token: 0x0600612E RID: 24878
	public abstract string Category { get; }

	// Token: 0x0600612F RID: 24879 RVA: 0x002A5E48 File Offset: 0x002A4048
	public s0()
	{
	}

	// Token: 0x06006130 RID: 24880
	public abstract string ek(e3q A_0);

	// Token: 0x06006131 RID: 24881
	public abstract string eo(e3q A_0);

	// Token: 0x06006132 RID: 24882
	public abstract string el(e3q A_0);

	// Token: 0x06006133 RID: 24883
	public abstract string ep(e3q A_0);

	// Token: 0x06006134 RID: 24884
	public abstract bool em(e3q A_0);

	// Token: 0x06006135 RID: 24885
	public abstract void en(e3q A_0, c5x A_1);

	// Token: 0x0400295C RID: 10588
	private int a;
}
