using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020004A3 RID: 1187
[eiz("P1")]
[Serializable]
public sealed class d22 : ISerializable
{
	// Token: 0x06001E2C RID: 7724 RVA: 0x000A7FC8 File Offset: 0x000A61C8
	private d22(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetString("P1:F");
			this.b = (Color)A_0.GetValue("P1:C", typeof(Color));
			if (ell.a() >= 645)
			{
				this.c = A_0.GetValue("P1:T", typeof(object));
				return;
			}
		}
		else
		{
			if (base.GetType() == typeof(d22))
			{
				this.a = A_0.GetString("Font");
				this.b = (Color)A_0.GetValue("Color", typeof(Color));
				return;
			}
			this.a = A_0.GetString("Pen+Font");
			this.b = (Color)A_0.GetValue("Pen+Color", typeof(Color));
		}
	}

	// Token: 0x06001E2D RID: 7725 RVA: 0x000A80C0 File Offset: 0x000A62C0
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("P1:F", this.a);
		info.AddValue("P1:C", this.b);
		info.AddValue("P1:T", this.c);
	}

	// Token: 0x06001E2E RID: 7726 RVA: 0x000A80FC File Offset: 0x000A62FC
	public d22(string A_0, Color A_1)
	{
		czh.a(A_0, "font");
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x06001E2F RID: 7727 RVA: 0x000A8120 File Offset: 0x000A6320
	public d22 a()
	{
		return new d22(this.a, this.b);
	}

	// Token: 0x04001349 RID: 4937
	public string a;

	// Token: 0x0400134A RID: 4938
	public Color b;

	// Token: 0x0400134B RID: 4939
	public object c;
}
