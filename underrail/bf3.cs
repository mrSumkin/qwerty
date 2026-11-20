using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020011AE RID: 4526
[eiz("EJPP")]
[Serializable]
public sealed class bf3 : bdw, ISerializable
{
	// Token: 0x06006069 RID: 24681 RVA: 0x002A2B2C File Offset: 0x002A0D2C
	private bf3(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = (A_0.GetValue("EJPP:J", typeof(cze)) as cze);
		if (ell.a() >= 154)
		{
			this.b = (A_0.GetValue("EJPP:C", typeof(Dictionary<string, object>)) as Dictionary<string, object>);
		}
	}

	// Token: 0x0600606A RID: 24682 RVA: 0x002A2B9C File Offset: 0x002A0D9C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("EJPP:J", this.a);
		info.AddValue("EJPP:C", this.b);
	}

	// Token: 0x0600606B RID: 24683 RVA: 0x002A2BC0 File Offset: 0x002A0DC0
	public cze a()
	{
		return this.a;
	}

	// Token: 0x0600606C RID: 24684 RVA: 0x002A2BC8 File Offset: 0x002A0DC8
	public void a(cze A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600606D RID: 24685 RVA: 0x002A2BD4 File Offset: 0x002A0DD4
	public Dictionary<string, object> b()
	{
		return this.b;
	}

	// Token: 0x0600606E RID: 24686 RVA: 0x002A2BDC File Offset: 0x002A0DDC
	public void a(Dictionary<string, object> A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600606F RID: 24687 RVA: 0x002A2BE8 File Offset: 0x002A0DE8
	public bf3()
	{
	}

	// Token: 0x06006070 RID: 24688 RVA: 0x002A2BFC File Offset: 0x002A0DFC
	public void av(c1a A_0, cyt A_1)
	{
		if (this.a != null)
		{
			this.a.ym(null, null, this.b);
		}
	}

	// Token: 0x04002915 RID: 10517
	private cze a;

	// Token: 0x04002916 RID: 10518
	private Dictionary<string, object> b = new Dictionary<string, object>();
}
