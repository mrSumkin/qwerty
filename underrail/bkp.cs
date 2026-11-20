using System;
using System.Runtime.Serialization;

// Token: 0x0200114E RID: 4430
[eiz("XA0")]
[Serializable]
public sealed class bkp : ISerializable
{
	// Token: 0x06005EE9 RID: 24297 RVA: 0x00283EFC File Offset: 0x002820FC
	private bkp(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetInt32("XA0:R");
	}

	// Token: 0x06005EEA RID: 24298 RVA: 0x00283F18 File Offset: 0x00282118
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("XA0:R", this.a);
	}

	// Token: 0x06005EEB RID: 24299 RVA: 0x00283F2C File Offset: 0x0028212C
	public bool a()
	{
		return this.a == 0;
	}

	// Token: 0x06005EEC RID: 24300 RVA: 0x00283F38 File Offset: 0x00282138
	public bkp(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005EED RID: 24301 RVA: 0x00283F48 File Offset: 0x00282148
	public void a(ot A_0)
	{
		A_0.akj(new EventHandler<EventArgs>(this.a));
	}

	// Token: 0x06005EEE RID: 24302 RVA: 0x00283F5C File Offset: 0x0028215C
	public void b()
	{
		if (this.a > 0)
		{
			this.a--;
		}
	}

	// Token: 0x06005EEF RID: 24303 RVA: 0x00283F78 File Offset: 0x00282178
	private void a(object A_0, EventArgs A_1)
	{
		if (this.a > 0)
		{
			this.a--;
		}
		ot ot = A_0 as ot;
		if (ot != null)
		{
			ot.akk(new EventHandler<EventArgs>(this.a));
		}
	}

	// Token: 0x040025BE RID: 9662
	private int a;
}
