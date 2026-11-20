using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x0200112B RID: 4395
[eiz("SSEAFX")]
[Serializable]
public sealed class rp : cze, ISerializable
{
	// Token: 0x06005E09 RID: 24073 RVA: 0x0027D9F0 File Offset: 0x0027BBF0
	private rp(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetInt32("SSEAFX:V");
			return;
		}
		if (base.GetType() == typeof(rp))
		{
			this.a = A_0.GetInt32("_Value");
			return;
		}
		this.a = A_0.GetInt32("SetSimpleEntityAspectFrameX+_Value");
	}

	// Token: 0x06005E0A RID: 24074 RVA: 0x0027DA60 File Offset: 0x0027BC60
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SSEAFX:V", this.a);
	}

	// Token: 0x06005E0B RID: 24075 RVA: 0x0027DA7C File Offset: 0x0027BC7C
	public int a()
	{
		return this.a;
	}

	// Token: 0x06005E0C RID: 24076 RVA: 0x0027DA84 File Offset: 0x0027BC84
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005E0D RID: 24077 RVA: 0x0027DA90 File Offset: 0x0027BC90
	public rp()
	{
	}

	// Token: 0x06005E0E RID: 24078 RVA: 0x0027DA98 File Offset: 0x0027BC98
	public rp(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005E0F RID: 24079 RVA: 0x0027DAAC File Offset: 0x0027BCAC
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null)
		{
			cd0 aspect = A_1.GetAspect<cd0>();
			if (aspect != null)
			{
				aspect.b = new Point(this.a, aspect.b.Y);
			}
		}
	}

	// Token: 0x04002568 RID: 9576
	private new int a;
}
