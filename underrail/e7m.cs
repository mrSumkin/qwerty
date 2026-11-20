using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020010A1 RID: 4257
[eiz("MACJ")]
[Serializable]
public sealed class e7m : cze, ISerializable
{
	// Token: 0x06005941 RID: 22849 RVA: 0x00269D9C File Offset: 0x00267F9C
	private e7m(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("MACJ:A");
		this.b = A_0.GetBoolean("MACJ:S");
		if (ell.a() >= 548)
		{
			this.c = A_0.GetBoolean("MACJ:X");
			return;
		}
		this.c = true;
	}

	// Token: 0x06005942 RID: 22850 RVA: 0x00269E0C File Offset: 0x0026800C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MACJ:A", this.a);
		info.AddValue("MACJ:S", this.b);
		info.AddValue("MACJ:X", this.b);
	}

	// Token: 0x06005943 RID: 22851 RVA: 0x00269E54 File Offset: 0x00268054
	public int c()
	{
		return this.a;
	}

	// Token: 0x06005944 RID: 22852 RVA: 0x00269E5C File Offset: 0x0026805C
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005945 RID: 22853 RVA: 0x00269E68 File Offset: 0x00268068
	public bool a()
	{
		return this.b;
	}

	// Token: 0x06005946 RID: 22854 RVA: 0x00269E70 File Offset: 0x00268070
	public void b(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005947 RID: 22855 RVA: 0x00269E7C File Offset: 0x0026807C
	public bool b()
	{
		return this.c;
	}

	// Token: 0x06005948 RID: 22856 RVA: 0x00269E84 File Offset: 0x00268084
	public void a(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005949 RID: 22857 RVA: 0x00269E90 File Offset: 0x00268090
	public e7m()
	{
	}

	// Token: 0x0600594A RID: 22858 RVA: 0x00269EAC File Offset: 0x002680AC
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null && c5x.h.b != null)
		{
			foreach (KeyValuePair<string, ip> keyValuePair in c5x.h.b.aa().Cooldowns.b())
			{
				ip value = keyValuePair.Value;
				if ((!this.b || keyValuePair.Key != e6g.c) && (!this.c || !keyValuePair.Value.d))
				{
					value.a += (double)(this.a * d0u.b);
				}
			}
		}
	}

	// Token: 0x040023E5 RID: 9189
	private new int a;

	// Token: 0x040023E6 RID: 9190
	private bool b = true;

	// Token: 0x040023E7 RID: 9191
	private bool c = true;
}
