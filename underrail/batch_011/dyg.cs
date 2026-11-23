using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001071 RID: 4209
[eiz("MEFOJ")]
[Serializable]
public sealed class dyg : cze
{
	// Token: 0x0600579A RID: 22426 RVA: 0x002632A4 File Offset: 0x002614A4
	private dyg(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetValue("MEFOJ:O", typeof(object));
	}

	// Token: 0x0600579B RID: 22427 RVA: 0x002632CC File Offset: 0x002614CC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MEFOJ:O", this.a);
	}

	// Token: 0x0600579C RID: 22428 RVA: 0x002632E8 File Offset: 0x002614E8
	public object a()
	{
		return this.a;
	}

	// Token: 0x0600579D RID: 22429 RVA: 0x002632F0 File Offset: 0x002614F0
	public void a(object A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600579E RID: 22430 RVA: 0x002632FC File Offset: 0x002614FC
	public dyg()
	{
	}

	// Token: 0x0600579F RID: 22431 RVA: 0x00263304 File Offset: 0x00261504
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_0 != null)
		{
			aw1.b(A_0, this.a, false);
		}
	}

	// Token: 0x0400236D RID: 9069
	private new object a;
}
