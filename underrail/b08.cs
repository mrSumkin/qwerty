using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020007C2 RID: 1986
[eiz("XPBLDEBBTJ")]
[Serializable]
public sealed class b08 : cze, ISerializable
{
	// Token: 0x060031BD RID: 12733 RVA: 0x00130A80 File Offset: 0x0012EC80
	private b08(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("XPBLDEBBTJ:R");
		this.b = A_0.GetString("XPBLDEBBTJ:B");
	}

	// Token: 0x060031BE RID: 12734 RVA: 0x00130AB4 File Offset: 0x0012ECB4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("XPBLDEBBTJ:R", this.a);
		info.AddValue("XPBLDEBBTJ:B", this.b);
	}

	// Token: 0x060031BF RID: 12735 RVA: 0x00130AE0 File Offset: 0x0012ECE0
	public int a()
	{
		return this.a;
	}

	// Token: 0x060031C0 RID: 12736 RVA: 0x00130AE8 File Offset: 0x0012ECE8
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060031C1 RID: 12737 RVA: 0x00130AF4 File Offset: 0x0012ECF4
	public string b()
	{
		return this.b;
	}

	// Token: 0x060031C2 RID: 12738 RVA: 0x00130AFC File Offset: 0x0012ECFC
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060031C3 RID: 12739 RVA: 0x00130B08 File Offset: 0x0012ED08
	public b08()
	{
	}

	// Token: 0x060031C4 RID: 12740 RVA: 0x00130B1C File Offset: 0x0012ED1C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null && A_2 != null)
		{
			object obj;
			A_2.TryGetValue("tickCount", out obj);
			if (obj is int)
			{
				apb apb = new apb();
				int num = this.a - 1;
				this.a = num;
				if (num <= 0)
				{
					string text = this.b;
					if (!(text == "bomb1"))
					{
						if (!(text == "bomb2"))
						{
							if (text == "bomb3")
							{
								apb.l(null, null, null);
							}
						}
						else
						{
							apb.m(null, null, null);
						}
					}
					else
					{
						apb.b(null, null, null);
					}
					c5x.w();
					c5x.an();
					return;
				}
				bmj.a(c5x, new efj(this.a));
				if (this.a == 34 || this.a == 75 || this.a == 105)
				{
					apb.a();
				}
			}
		}
	}

	// Token: 0x04001ABE RID: 6846
	private new int a = 100;

	// Token: 0x04001ABF RID: 6847
	private string b;
}
