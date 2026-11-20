using System;
using System.Runtime.Serialization;

// Token: 0x02000663 RID: 1635
[eiz("LPA")]
[Serializable]
public sealed class bw0 : ISerializable
{
	// Token: 0x06002983 RID: 10627 RVA: 0x000EC540 File Offset: 0x000EA740
	private bw0(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (bdw)A_0.GetValue("LPA:P", typeof(bdw));
			this.b = A_0.GetInt32("LPA:RR");
			this.c = A_0.GetString("LPA:TLI");
			return;
		}
		if (base.GetType() == typeof(bw0))
		{
			this.a = (bdw)A_0.GetValue("_Preprocessor", typeof(bdw));
			this.b = A_0.GetInt32("_RepetitionsRemaining");
			this.c = A_0.GetString("_TargetLocaleId");
			return;
		}
		this.a = (bdw)A_0.GetValue("LocalePreprocessingAction+_Preprocessor", typeof(bdw));
		this.b = A_0.GetInt32("LocalePreprocessingAction+_RepetitionsRemaining");
		this.c = A_0.GetString("LocalePreprocessingAction+_TargetLocaleId");
	}

	// Token: 0x06002984 RID: 10628 RVA: 0x000EC648 File Offset: 0x000EA848
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("LPA:P", this.a);
		info.AddValue("LPA:RR", this.b);
		info.AddValue("LPA:TLI", this.c);
	}

	// Token: 0x06002985 RID: 10629 RVA: 0x000EC680 File Offset: 0x000EA880
	public bdw b()
	{
		return this.a;
	}

	// Token: 0x06002986 RID: 10630 RVA: 0x000EC688 File Offset: 0x000EA888
	public int c()
	{
		return this.b;
	}

	// Token: 0x06002987 RID: 10631 RVA: 0x000EC690 File Offset: 0x000EA890
	public string a()
	{
		return this.c;
	}

	// Token: 0x06002988 RID: 10632 RVA: 0x000EC698 File Offset: 0x000EA898
	public bw0(string A_0, bdw A_1, int A_2 = 1)
	{
		this.c = A_0;
		this.a = A_1;
		if (A_2 == 0)
		{
			this.b = -100;
			return;
		}
		this.b = A_2;
	}

	// Token: 0x06002989 RID: 10633 RVA: 0x000EC6D0 File Offset: 0x000EA8D0
	public bool a(c1a A_0, cyt A_1)
	{
		if (this.a != null)
		{
			this.a.av(A_0, A_1);
		}
		if (this.b == -100)
		{
			return false;
		}
		int num = this.b - 1;
		this.b = num;
		return num <= 0;
	}

	// Token: 0x040016A4 RID: 5796
	private bdw a;

	// Token: 0x040016A5 RID: 5797
	private int b = 1;

	// Token: 0x040016A6 RID: 5798
	private string c;
}
