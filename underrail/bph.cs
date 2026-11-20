using System;
using System.Runtime.Serialization;

// Token: 0x020004A6 RID: 1190
[eiz("RTLS")]
[Serializable]
public sealed class bph : ISerializable
{
	// Token: 0x06001E3D RID: 7741 RVA: 0x000A8514 File Offset: 0x000A6714
	private bph(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (d22)A_0.GetValue("RTLS:P", typeof(d22));
			this.b = A_0.GetString("RTLS:T");
			if (ell.a() >= 676)
			{
				this.c = A_0.GetString("RTLS:I");
				return;
			}
		}
		else
		{
			if (base.GetType() == typeof(bph))
			{
				this.a = (d22)A_0.GetValue("Pen", typeof(d22));
				this.b = A_0.GetString("Text");
				return;
			}
			this.a = (d22)A_0.GetValue("RichTextLineSection+Pen", typeof(d22));
			this.b = A_0.GetString("RichTextLineSection+Text");
		}
	}

	// Token: 0x06001E3E RID: 7742 RVA: 0x000A8600 File Offset: 0x000A6800
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("RTLS:P", this.a);
		info.AddValue("RTLS:T", this.b);
		info.AddValue("RTLS:I", this.c);
	}

	// Token: 0x06001E3F RID: 7743 RVA: 0x000A8638 File Offset: 0x000A6838
	public bph(d22 A_0, string A_1, string A_2 = null)
	{
		czh.a(A_0, "pen");
		this.a = A_0;
		this.b = A_1;
		this.c = A_2;
	}

	// Token: 0x0400134F RID: 4943
	public d22 a;

	// Token: 0x04001350 RID: 4944
	public string b;

	// Token: 0x04001351 RID: 4945
	public string c;
}
