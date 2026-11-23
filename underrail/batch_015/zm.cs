using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Aspects;

// Token: 0x02001267 RID: 4711
[eiz("ADSCEA")]
[Serializable]
public sealed class zm : Aspect<c5x>, ISerializable, bp1, c98
{
	// Token: 0x06006614 RID: 26132 RVA: 0x002B697C File Offset: 0x002B4B7C
	private zm(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("ADSCEA:P");
	}

	// Token: 0x06006615 RID: 26133 RVA: 0x002B6998 File Offset: 0x002B4B98
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("ADSCEA:P", this.a);
	}

	// Token: 0x06006616 RID: 26134 RVA: 0x002B69B4 File Offset: 0x002B4BB4
	public zm(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006617 RID: 26135 RVA: 0x002B69C0 File Offset: 0x002B4BC0
	public void r7(eds A_0)
	{
		if (!this.a)
		{
			this.a = true;
			foreach (ak1 ak in base.a8().l)
			{
				if (ak.a(dm9.b))
				{
					foreach (b0b b0b in ak.c.Values)
					{
						c5x c5x = (c5x)b0b;
						Color? value;
						if (c5x != base.a8() && c5x.r.TryGetValue(dm9.a, out value) && value != null)
						{
							base.a8().r[dm9.a] = value;
							break;
						}
					}
					base.a8().a(dm9.a);
					break;
				}
			}
		}
	}

	// Token: 0x06006618 RID: 26136 RVA: 0x002B6AE4 File Offset: 0x002B4CE4
	public void mx()
	{
		this.a = false;
	}

	// Token: 0x06006619 RID: 26137 RVA: 0x002B6AF0 File Offset: 0x002B4CF0
	public void my()
	{
		this.a = false;
	}

	// Token: 0x04002A6B RID: 10859
	private bool a;
}
