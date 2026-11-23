using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;
using TimelapseVertigo.Game.Data;

// Token: 0x0200113F RID: 4415
[eiz("TRSMA")]
[Serializable]
public sealed class ay0 : Aspect<c5x>, ISerializable, bp1
{
	// Token: 0x06005E7B RID: 24187 RVA: 0x00280AC0 File Offset: 0x0027ECC0
	private ay0(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() >= 464)
		{
			di7.ReadList<string>("TRSMA:L1", ref this.c, A_0);
			di7.ReadList<string>("TRSMA:L2", ref this.d, A_0);
		}
		else
		{
			string @string = A_0.GetString("TRSMA:L1");
			string string2 = A_0.GetString("TRSMA:L2");
			this.c = new List<string>();
			this.c.Add(@string);
			this.d = new List<string>();
			this.d.Add(string2);
		}
		this.a = (MapNodeState)A_0.GetValue("TRSMA:I", typeof(MapNodeState));
		this.b = (MapNodeState)A_0.GetValue("TRSMA:S", typeof(MapNodeState));
	}

	// Token: 0x06005E7C RID: 24188 RVA: 0x00280BA8 File Offset: 0x0027EDA8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<string>("TRSMA:L1", this.c, info);
		di7.WriteList<string>("TRSMA:L2", this.d, info);
		info.AddValue("TRSMA:I", this.a);
		info.AddValue("TRSMA:S", this.b);
	}

	// Token: 0x06005E7D RID: 24189 RVA: 0x00280C0C File Offset: 0x0027EE0C
	public List<string> b()
	{
		return this.c;
	}

	// Token: 0x06005E7E RID: 24190 RVA: 0x00280C14 File Offset: 0x0027EE14
	public void b(List<string> A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005E7F RID: 24191 RVA: 0x00280C20 File Offset: 0x0027EE20
	public List<string> d()
	{
		return this.d;
	}

	// Token: 0x06005E80 RID: 24192 RVA: 0x00280C28 File Offset: 0x0027EE28
	public void a(List<string> A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06005E81 RID: 24193 RVA: 0x00280C34 File Offset: 0x0027EE34
	public MapNodeState e()
	{
		return this.a;
	}

	// Token: 0x06005E82 RID: 24194 RVA: 0x00280C3C File Offset: 0x0027EE3C
	public void b(MapNodeState A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005E83 RID: 24195 RVA: 0x00280C48 File Offset: 0x0027EE48
	public MapNodeState a()
	{
		return this.b;
	}

	// Token: 0x06005E84 RID: 24196 RVA: 0x00280C50 File Offset: 0x0027EE50
	public void a(MapNodeState A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005E85 RID: 24197 RVA: 0x00280C5C File Offset: 0x0027EE5C
	public ay0(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06005E86 RID: 24198 RVA: 0x00280C80 File Offset: 0x0027EE80
	public void mx()
	{
		e3l e3l = base.a8().GetAspect<e3l>();
		if (e3l == null)
		{
			e3l = new e3l(base.a8());
			base.a8().SetAspect<e3l>(e3l);
		}
		e3l.a.Clear();
		foreach (string text in this.c)
		{
			foreach (string text2 in this.d)
			{
				if (!string.IsNullOrWhiteSpace(text) && !string.IsNullOrWhiteSpace(text2))
				{
					e3l.a.Add("TransitionMapNode");
					string item = ay0.a(text, text2);
					e3l.a.Add(item);
				}
			}
		}
	}

	// Token: 0x06005E87 RID: 24199 RVA: 0x00280D8C File Offset: 0x0027EF8C
	public void my()
	{
	}

	// Token: 0x06005E88 RID: 24200 RVA: 0x00280D90 File Offset: 0x0027EF90
	private static string a(string A_0, string A_1)
	{
		return string.Format("TransitionRepresenter_{0}", dfz.a(A_0, A_1));
	}

	// Token: 0x0400258A RID: 9610
	private MapNodeState a;

	// Token: 0x0400258B RID: 9611
	private MapNodeState b;

	// Token: 0x0400258C RID: 9612
	private List<string> c = new List<string>();

	// Token: 0x0400258D RID: 9613
	private List<string> d = new List<string>();
}
