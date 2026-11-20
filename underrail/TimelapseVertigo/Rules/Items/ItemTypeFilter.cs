using System;
using System.Runtime.Serialization;

namespace TimelapseVertigo.Rules.Items
{
	// Token: 0x0200222B RID: 8747
	[eiz("ITF")]
	[Serializable]
	public class ItemTypeFilter<T> : bp2, ISerializable where T : bk3
	{
		// Token: 0x0600CAEF RID: 51951 RVA: 0x0047D9FC File Offset: 0x0047BBFC
		public ItemTypeFilter()
		{
		}

		// Token: 0x0600CAF0 RID: 51952 RVA: 0x0047DA04 File Offset: 0x0047BC04
		public ItemTypeFilter(string A_0)
		{
			this.a = A_0;
		}

		// Token: 0x0600CAF1 RID: 51953 RVA: 0x0047DA14 File Offset: 0x0047BC14
		public bool cx(coh A_0)
		{
			return A_0.Definition is T;
		}

		// Token: 0x0600CAF2 RID: 51954 RVA: 0x0047DA24 File Offset: 0x0047BC24
		public override string ToString()
		{
			if (!string.IsNullOrEmpty(this.a))
			{
				return this.a;
			}
			return base.ToString();
		}

		// Token: 0x0600CAF3 RID: 51955 RVA: 0x0047DA44 File Offset: 0x0047BC44
		protected ItemTypeFilter(SerializationInfo A_0, StreamingContext A_1)
		{
			this.a = A_0.GetString("ITF:N");
		}

		// Token: 0x0600CAF4 RID: 51956 RVA: 0x0047DA60 File Offset: 0x0047BC60
		public virtual void GetObjectData(SerializationInfo info, StreamingContext ctx)
		{
			info.AddValue("ITF:N", this.a);
		}

		// Token: 0x04004B0B RID: 19211
		private string a;
	}
}
