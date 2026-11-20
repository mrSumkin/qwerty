using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;

// Token: 0x02001087 RID: 4231
[eiz("ILJ")]
[Serializable]
public sealed class edv : cze, ISerializable
{
	// Token: 0x0600583E RID: 22590 RVA: 0x0026527C File Offset: 0x0026347C
	private edv(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("ILJ:LN");
	}

	// Token: 0x0600583F RID: 22591 RVA: 0x00265298 File Offset: 0x00263498
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("ILJ:LN", this.a);
	}

	// Token: 0x06005840 RID: 22592 RVA: 0x002652B4 File Offset: 0x002634B4
	public string a()
	{
		return this.a;
	}

	// Token: 0x06005841 RID: 22593 RVA: 0x002652BC File Offset: 0x002634BC
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005842 RID: 22594 RVA: 0x002652C8 File Offset: 0x002634C8
	public edv()
	{
	}

	// Token: 0x06005843 RID: 22595 RVA: 0x002652D4 File Offset: 0x002634D4
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c1a c1a = null;
		if (A_0 != null)
		{
			c1a = A_0.Zone;
		}
		else if (A_1 != null)
		{
			c1a = A_1.Zone;
		}
		if (c1a != null)
		{
			doq a_ = doq.a(Path.Combine(d5x.q(), c1a.y8() + "_" + this.a) + ".uzl");
			c1a.a(a_, 1, null);
		}
	}

	// Token: 0x04002397 RID: 9111
	private new string a;
}
