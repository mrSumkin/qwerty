using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x0200048F RID: 1167
[eiz("ID")]
[Serializable]
public sealed class bj8 : ISerializable
{
	// Token: 0x06001DDA RID: 7642 RVA: 0x000A5B94 File Offset: 0x000A3D94
	private bj8(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			this.b = A_0.GetString("ID:N");
			this.c = (Vector2)A_0.GetValue("ID:S", typeof(Vector2));
			di7.ReadList<d8h>("ID:P", ref this.d, A_0);
			return;
		}
		if (base.GetType() == typeof(bj8))
		{
			this.b = A_0.GetString("_Name");
			this.c = (Vector2)A_0.GetValue("_Size", typeof(Vector2));
			this.d = (List<d8h>)A_0.GetValue("_Parts", typeof(List<d8h>));
			return;
		}
		this.b = A_0.GetString("IconDescription+_Name");
		this.c = (Vector2)A_0.GetValue("IconDescription+_Size", typeof(Vector2));
		this.d = (List<d8h>)A_0.GetValue("IconDescription+_Parts", typeof(List<d8h>));
	}

	// Token: 0x06001DDB RID: 7643 RVA: 0x000A5CE0 File Offset: 0x000A3EE0
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("ID:N", this.b);
		info.AddValue("ID:S", this.c);
		di7.WriteList<d8h>("ID:P", this.d, info);
	}

	// Token: 0x06001DDC RID: 7644 RVA: 0x000A5D1C File Offset: 0x000A3F1C
	public string c()
	{
		return this.b;
	}

	// Token: 0x06001DDD RID: 7645 RVA: 0x000A5D24 File Offset: 0x000A3F24
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06001DDE RID: 7646 RVA: 0x000A5D30 File Offset: 0x000A3F30
	public Vector2 b()
	{
		return this.c;
	}

	// Token: 0x06001DDF RID: 7647 RVA: 0x000A5D38 File Offset: 0x000A3F38
	public void a(Vector2 A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06001DE0 RID: 7648 RVA: 0x000A5D44 File Offset: 0x000A3F44
	public List<d8h> a()
	{
		return this.d;
	}

	// Token: 0x06001DE1 RID: 7649 RVA: 0x000A5D4C File Offset: 0x000A3F4C
	public void a(List<d8h> A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06001DE2 RID: 7650 RVA: 0x000A5D58 File Offset: 0x000A3F58
	public bj8()
	{
	}

	// Token: 0x04001288 RID: 4744
	public static readonly esj a = new esj(33, 33);

	// Token: 0x04001289 RID: 4745
	private string b;

	// Token: 0x0400128A RID: 4746
	private Vector2 c = new Vector2((float)bj8.a.c, (float)bj8.a.d);

	// Token: 0x0400128B RID: 4747
	private List<d8h> d = new List<d8h>();
}
