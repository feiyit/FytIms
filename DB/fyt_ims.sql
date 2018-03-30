/*
Navicat MySQL Data Transfer

Source Server         : fyt
Source Server Version : 50719
Source Host           : localhost:3306
Source Database       : fyt_ims

Target Server Type    : MYSQL
Target Server Version : 50719
File Encoding         : 65001

Date: 2018-03-30 16:59:28
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for syscode
-- ----------------------------
DROP TABLE IF EXISTS `syscode`;
CREATE TABLE `syscode` (
  `Guid` varchar(50) NOT NULL COMMENT '唯一标号Guid',
  `ParentGuid` varchar(50) NOT NULL COMMENT '字典类型标识',
  `CodeType` varchar(50) DEFAULT NULL COMMENT '字典值——类型',
  `Name` varchar(255) NOT NULL COMMENT '字典值——名称',
  `EnName` varchar(255) DEFAULT NULL COMMENT '字典值——英文名称',
  `Sort` int(11) NOT NULL DEFAULT '0' COMMENT '字典值——排序',
  `Status` bit(1) NOT NULL DEFAULT b'1' COMMENT '字典值——状态',
  `Summary` varchar(1000) DEFAULT NULL COMMENT '字典值——描述',
  `AddTime` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '字典值——添加时间',
  `EditTime` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '字典值——修改时间',
  PRIMARY KEY (`Guid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of syscode
-- ----------------------------
INSERT INTO `syscode` VALUES ('00fca0bf-e26c-4a17-b0bb-29fd3c2ad701', '21576fef-1a5b-4af8-a394-ec5166b4a8e4', '1011', '台盟盟员', null, '24', '', null, '2018-03-29 12:30:43', '2018-03-29 12:30:43');
INSERT INTO `syscode` VALUES ('042e6708-3303-4fa0-8cf1-2958d5144cd0', '1f1db281-ce59-42ca-9647-26f7fb882b2e', '1002', '经济与贸易', null, '46', '', null, '2018-03-30 14:24:04', '2018-03-30 14:24:04');
INSERT INTO `syscode` VALUES ('0975c3e9-c1e5-4864-bc9c-80de58c37c9d', 'e9b04253-49a3-47bc-82e2-53d506fda641', '1003', '满族', null, '29', '', null, '2018-03-29 12:39:19', '2018-03-29 12:39:19');
INSERT INTO `syscode` VALUES ('0d8bbb2b-dc2d-4744-ac95-6a45ca6a1963', 'e9b04253-49a3-47bc-82e2-53d506fda641', '1002', '蒙古族', null, '28', '', null, '2018-03-29 12:39:12', '2018-03-29 12:39:12');
INSERT INTO `syscode` VALUES ('1537252f-88cd-4189-a7e8-bd646c602f5c', 'b3767d9d-2ecc-48c5-b56d-d9af628c0c63', '1008', '博士', null, '10', '', null, '2018-03-29 12:27:31', '2018-03-29 12:27:31');
INSERT INTO `syscode` VALUES ('18d55180-c690-4f82-bf81-0e6b5e61dada', '6ceddac9-c24a-4e36-bcc3-33d31a2d737e', '1001', '国立', null, '42', '', null, '2018-03-30 14:23:07', '2018-03-30 14:23:07');
INSERT INTO `syscode` VALUES ('1a0b73f2-3ed6-4818-9bc0-5f4960f58703', 'b3767d9d-2ecc-48c5-b56d-d9af628c0c63', '1002', '初中', null, '4', '', null, '2018-03-29 12:26:54', '2018-03-29 12:26:54');
INSERT INTO `syscode` VALUES ('1f722c76-cc36-416e-855f-7a2c4ecac12f', 'd14fb7c9-e867-467e-94fa-9f1a94692b88', '1003', '日语', null, '13', '', null, '2018-03-29 13:51:50', '2018-03-29 13:51:51');
INSERT INTO `syscode` VALUES ('21ba8e52-3336-41d7-9567-dc376f7e44ec', '21576fef-1a5b-4af8-a394-ec5166b4a8e4', '1001', '中共党员', null, '14', '', null, '2018-03-29 12:29:38', '2018-03-29 12:29:39');
INSERT INTO `syscode` VALUES ('27a399ca-9415-4a39-84c7-88cae944ca25', 'e9b04253-49a3-47bc-82e2-53d506fda641', '1001', '汉族', null, '27', '', null, '2018-03-29 12:38:36', '2018-03-29 12:38:36');
INSERT INTO `syscode` VALUES ('2949c266-575a-4e5d-a663-e39d5f33df7e', '2128dd06-6414-44e4-ae83-502f58d886d2', '1001', '已婚', null, '37', '', null, '2018-03-29 12:41:10', '2018-03-29 12:41:10');
INSERT INTO `syscode` VALUES ('2999af31-6d30-4c9e-a8e2-9331c537b361', 'b3767d9d-2ecc-48c5-b56d-d9af628c0c63', '1004', '高中', null, '6', '', null, '2018-03-29 12:27:07', '2018-03-29 12:27:07');
INSERT INTO `syscode` VALUES ('29ee3b9c-b426-4e11-a3a9-f8ba2cfa1a19', '21576fef-1a5b-4af8-a394-ec5166b4a8e4', '1003', '共青团员', null, '16', '', null, '2018-03-29 12:29:53', '2018-03-29 12:29:53');
INSERT INTO `syscode` VALUES ('2d42a5cc-9911-4807-9b1e-b29595dacb9b', 'b3767d9d-2ecc-48c5-b56d-d9af628c0c63', '1007', '硕士', null, '9', '', null, '2018-03-29 12:27:24', '2018-03-29 12:27:24');
INSERT INTO `syscode` VALUES ('2f3fcc5e-737b-4ae8-8e8d-4a9b0032453c', '1f1db281-ce59-42ca-9647-26f7fb882b2e', '1001', '计算机专业', null, '45', '', null, '2018-03-30 14:23:33', '2018-03-30 14:23:33');
INSERT INTO `syscode` VALUES ('331dcdc9-a57a-42a3-9f5e-49fb156fd030', '21576fef-1a5b-4af8-a394-ec5166b4a8e4', '1012', '无党派人士', null, '25', '', null, '2018-03-29 12:30:58', '2018-03-29 12:30:58');
INSERT INTO `syscode` VALUES ('3c9cae16-42dd-482b-804a-da75b3d7a160', '21576fef-1a5b-4af8-a394-ec5166b4a8e4', '1006', '民建会员', null, '19', '', null, '2018-03-29 12:30:09', '2018-03-29 12:30:09');
INSERT INTO `syscode` VALUES ('439083c4-c62d-459f-9564-c9ae85fd5320', 'b3767d9d-2ecc-48c5-b56d-d9af628c0c63', '1001', '小学', null, '3', '', null, '2018-03-29 12:26:24', '2018-03-29 12:26:24');
INSERT INTO `syscode` VALUES ('484a55b2-410b-428a-bdaa-54f6f48d4219', '21576fef-1a5b-4af8-a394-ec5166b4a8e4', '1009', '致公党党员', null, '22', '', null, '2018-03-29 12:30:27', '2018-03-29 12:30:27');
INSERT INTO `syscode` VALUES ('4c8cbfd1-5aad-4019-98cd-3c9dfd667257', '21576fef-1a5b-4af8-a394-ec5166b4a8e4', '1008', '农工党党员', null, '21', '', null, '2018-03-29 12:30:21', '2018-03-29 12:30:21');
INSERT INTO `syscode` VALUES ('515ba6ca-4f37-48ad-b88c-0a444ab13d49', '36eefb08-1a44-4989-b4dc-e7be65e32349', '1005', '价值观信仰', null, '34', '', '道德主义、律法主义、自由主义、功利主义、拜金主义', '2018-03-29 12:40:38', '2018-03-29 12:40:38');
INSERT INTO `syscode` VALUES ('72fd052f-15e7-499b-9bc1-7eee1b5d6f8c', '59dd330c-13a5-4ef8-9e86-918e95b5b1e2', '1001', '男', null, '1', '', null, '2018-03-29 12:15:47', '2018-03-29 12:15:47');
INSERT INTO `syscode` VALUES ('74a40e09-36bf-4311-808d-f8fb7142374a', '36eefb08-1a44-4989-b4dc-e7be65e32349', '1002', '政治信仰', null, '31', '', '三民主义、共产主义、自由民主、天赋人权', '2018-03-29 12:40:16', '2018-03-29 12:40:17');
INSERT INTO `syscode` VALUES ('74d07de9-2ba5-4bf0-b9a4-5061321d6b48', 'd14fb7c9-e867-467e-94fa-9f1a94692b88', '1005', '葡萄言语', null, '41', '', null, '2018-03-29 13:52:07', '2018-03-29 13:52:07');
INSERT INTO `syscode` VALUES ('800bd8d9-eccd-4e14-8642-e30046e835b2', '2128dd06-6414-44e4-ae83-502f58d886d2', '1003', '保密', null, '39', '', null, '2018-03-29 12:41:28', '2018-03-29 12:41:28');
INSERT INTO `syscode` VALUES ('8df42099-7001-41ee-9e28-736b1ab6d71f', 'b3767d9d-2ecc-48c5-b56d-d9af628c0c63', '1003', '中专', null, '5', '', null, '2018-03-29 12:27:02', '2018-03-29 12:27:02');
INSERT INTO `syscode` VALUES ('8e37481c-db25-4b7a-929b-0f0a5bd05e5d', 'b3767d9d-2ecc-48c5-b56d-d9af628c0c63', '1006', '本科', null, '8', '', null, '2018-03-29 12:27:19', '2018-03-29 12:27:19');
INSERT INTO `syscode` VALUES ('9593506f-193a-4503-8929-e88cb13be728', '6ceddac9-c24a-4e36-bcc3-33d31a2d737e', '1002', '私立', null, '43', '', null, '2018-03-30 14:23:16', '2018-03-30 14:23:16');
INSERT INTO `syscode` VALUES ('9b5b8286-3021-4809-addd-18a334076518', '59dd330c-13a5-4ef8-9e86-918e95b5b1e2', '1002', '女', null, '2', '', null, '2018-03-28 18:41:02', '2018-03-28 18:41:03');
INSERT INTO `syscode` VALUES ('9d484458-5dad-4233-b18e-c5d37f185f13', 'd14fb7c9-e867-467e-94fa-9f1a94692b88', '1002', '英语', null, '12', '', null, '2018-03-29 13:51:45', '2018-03-29 13:51:46');
INSERT INTO `syscode` VALUES ('a773fdd3-952c-4b15-bff5-19e92462863a', '36eefb08-1a44-4989-b4dc-e7be65e32349', '1001', '神学信仰', null, '30', '', '一神信仰、多神信仰、泛神信仰、无神信仰', '2018-03-29 12:40:20', '2018-03-29 12:40:20');
INSERT INTO `syscode` VALUES ('ad01ceee-5394-444c-9a0a-00dfbb7c6d0a', 'b3767d9d-2ecc-48c5-b56d-d9af628c0c63', '1005', '大专', null, '7', '', null, '2018-03-29 12:27:14', '2018-03-29 12:27:14');
INSERT INTO `syscode` VALUES ('b6ec418c-738e-4fbd-92a3-1805fc14bb72', '36eefb08-1a44-4989-b4dc-e7be65e32349', '1004', '科学信仰', null, '33', '', '进化论、设计论、年前地球论、年老地球论、无限膨胀论', '2018-03-29 12:40:29', '2018-03-29 12:40:29');
INSERT INTO `syscode` VALUES ('ba317503-58fe-42fc-ba6e-1bda17cbb2d7', '21576fef-1a5b-4af8-a394-ec5166b4a8e4', '1007', '民进会员', null, '20', '', null, '2018-03-29 12:30:16', '2018-03-29 12:30:16');
INSERT INTO `syscode` VALUES ('bdf398e0-cd54-49a4-8623-4262309fa7d6', '36eefb08-1a44-4989-b4dc-e7be65e32349', '1006', '社会观信仰', null, '35', '', '自我主义、社群主义、爱国主义、民族主义、国际主义', '2018-03-29 12:40:49', '2018-03-29 12:40:49');
INSERT INTO `syscode` VALUES ('bf69cf81-d484-4fc8-bd2e-da88c737c799', '21576fef-1a5b-4af8-a394-ec5166b4a8e4', '1013', '群众', null, '26', '', null, '2018-03-29 12:31:08', '2018-03-29 12:31:08');
INSERT INTO `syscode` VALUES ('c485c665-8997-4105-9ecb-dc997bff9c73', '21576fef-1a5b-4af8-a394-ec5166b4a8e4', '1002', '中共预备党员', null, '15', '', null, '2018-03-29 12:29:47', '2018-03-29 12:29:47');
INSERT INTO `syscode` VALUES ('ca3a1e29-1864-4747-8a29-39bdedc466d3', '21576fef-1a5b-4af8-a394-ec5166b4a8e4', '1004', '民革党员', null, '17', '', null, '2018-03-29 12:29:58', '2018-03-29 12:29:58');
INSERT INTO `syscode` VALUES ('cb4c0674-7646-4c4e-8404-35bdd50e2fb6', 'd14fb7c9-e867-467e-94fa-9f1a94692b88', '1001', '汉语', null, '11', '', null, '2018-03-29 13:51:40', '2018-03-29 13:51:41');
INSERT INTO `syscode` VALUES ('d79c9866-de4a-4a5c-a243-4ab79783a860', '2128dd06-6414-44e4-ae83-502f58d886d2', '1002', '未婚', null, '38', '', null, '2018-03-29 12:41:17', '2018-03-29 12:41:17');
INSERT INTO `syscode` VALUES ('d90d8b10-b4a4-459b-a976-1ae911996cd7', '6ceddac9-c24a-4e36-bcc3-33d31a2d737e', '1003', '职业培训', null, '44', '', null, '2018-03-30 14:23:24', '2018-03-30 14:23:24');
INSERT INTO `syscode` VALUES ('e02c378f-9ca4-409c-9d44-c340944560b6', '36eefb08-1a44-4989-b4dc-e7be65e32349', '1007', '财富观信仰', null, '36', '', '按劳分配、按需分配、平均分配、计效分配', '2018-03-29 12:40:59', '2018-03-29 12:40:59');
INSERT INTO `syscode` VALUES ('e4d0d874-126c-4ac4-aa99-f5c7eebbd2b5', 'd14fb7c9-e867-467e-94fa-9f1a94692b88', '1004', '法语', null, '40', '', null, '2018-03-29 13:52:00', '2018-03-29 13:52:00');
INSERT INTO `syscode` VALUES ('ea8b94e5-4bf9-4e7d-b861-83e8385a53c7', '21576fef-1a5b-4af8-a394-ec5166b4a8e4', '1005', '民盟盟员', null, '18', '', null, '2018-03-29 12:30:03', '2018-03-29 12:30:03');
INSERT INTO `syscode` VALUES ('ef24276c-173c-4912-8d85-62d89956b79d', '36eefb08-1a44-4989-b4dc-e7be65e32349', '1003', '哲学信仰', null, '32', '', '唯物主义、唯心主义、虚空主义', '2018-03-29 12:40:11', '2018-03-29 12:40:11');
INSERT INTO `syscode` VALUES ('f51ad49a-fcd3-48ee-b2b8-ac789b732dd4', '1f1db281-ce59-42ca-9647-26f7fb882b2e', '1003', '政治学', null, '47', '', null, '2018-03-30 14:24:17', '2018-03-30 14:24:17');
INSERT INTO `syscode` VALUES ('f57a726d-dd3e-4f65-af19-73ba9a71d483', '21576fef-1a5b-4af8-a394-ec5166b4a8e4', '1010', '九三学社社员', null, '23', '', null, '2018-03-29 12:30:33', '2018-03-29 12:30:33');

-- ----------------------------
-- Table structure for syscodetype
-- ----------------------------
DROP TABLE IF EXISTS `syscodetype`;
CREATE TABLE `syscodetype` (
  `Guid` varchar(50) NOT NULL COMMENT '唯一标号Guid',
  `ParentGuid` varchar(50) DEFAULT NULL COMMENT '字典类型父级',
  `Layer` int(11) NOT NULL DEFAULT '0' COMMENT '深度',
  `Name` varchar(50) NOT NULL COMMENT '字典类型名称',
  `Sort` int(11) NOT NULL DEFAULT '0' COMMENT '字典类型排序',
  `AddTime` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP,
  `EditTime` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '添加时间',
  `SiteGuid` varchar(50) DEFAULT NULL COMMENT '归属公司或站点',
  PRIMARY KEY (`Guid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of syscodetype
-- ----------------------------
INSERT INTO `syscodetype` VALUES ('1f1db281-ce59-42ca-9647-26f7fb882b2e', '2bbdd992-862e-476c-b54f-00c9e50dab61', '1', '专业', '11', '2018-03-30 14:22:39', '2018-03-30 14:22:39', null);
INSERT INTO `syscodetype` VALUES ('2128dd06-6414-44e4-ae83-502f58d886d2', '2bbdd992-862e-476c-b54f-00c9e50dab61', '1', '婚姻', '10', '2018-03-29 12:28:33', '2018-03-29 12:28:33', null);
INSERT INTO `syscodetype` VALUES ('21576fef-1a5b-4af8-a394-ec5166b4a8e4', '2bbdd992-862e-476c-b54f-00c9e50dab61', '1', '政治面貌', '7', '2018-03-29 12:28:14', '2018-03-29 12:28:14', null);
INSERT INTO `syscodetype` VALUES ('2bbdd992-862e-476c-b54f-00c9e50dab61', null, '0', '员工字典', '1', '2018-03-26 12:37:03', '2018-03-26 12:37:03', null);
INSERT INTO `syscodetype` VALUES ('36eefb08-1a44-4989-b4dc-e7be65e32349', '2bbdd992-862e-476c-b54f-00c9e50dab61', '1', '信仰', '9', '2018-03-29 12:28:27', '2018-03-29 12:28:27', null);
INSERT INTO `syscodetype` VALUES ('59dd330c-13a5-4ef8-9e86-918e95b5b1e2', '2bbdd992-862e-476c-b54f-00c9e50dab61', '1', '性别', '2', '2018-03-26 12:37:05', '2018-03-26 12:37:05', null);
INSERT INTO `syscodetype` VALUES ('6ceddac9-c24a-4e36-bcc3-33d31a2d737e', '2bbdd992-862e-476c-b54f-00c9e50dab61', '1', '院校类型', '12', '2018-03-30 14:22:54', '2018-03-30 14:22:54', null);
INSERT INTO `syscodetype` VALUES ('7b664e3e-f58a-4e66-8c0f-be1458541d14', '8d3158d6-e179-4046-99e9-53eb8c04ddb1', '1', '测试', '5', '2018-03-26 21:11:50', '2018-03-26 21:11:50', null);
INSERT INTO `syscodetype` VALUES ('8d3158d6-e179-4046-99e9-53eb8c04ddb1', null, '0', '其他字典', '4', '2018-03-26 21:11:44', '2018-03-26 21:11:44', null);
INSERT INTO `syscodetype` VALUES ('b3767d9d-2ecc-48c5-b56d-d9af628c0c63', '2bbdd992-862e-476c-b54f-00c9e50dab61', '1', '学历', '3', '2018-03-26 21:08:13', '2018-03-26 21:08:13', null);
INSERT INTO `syscodetype` VALUES ('d14fb7c9-e867-467e-94fa-9f1a94692b88', '2bbdd992-862e-476c-b54f-00c9e50dab61', '1', '语言能力', '6', '2018-03-29 12:27:58', '2018-03-29 12:27:58', null);
INSERT INTO `syscodetype` VALUES ('e9b04253-49a3-47bc-82e2-53d506fda641', '2bbdd992-862e-476c-b54f-00c9e50dab61', '1', '民族', '8', '2018-03-29 12:28:20', '2018-03-29 12:28:20', null);

-- ----------------------------
-- Table structure for syscompany
-- ----------------------------
DROP TABLE IF EXISTS `syscompany`;
CREATE TABLE `syscompany` (
  `Guid` varchar(50) NOT NULL,
  `ParentGuid` varchar(50) DEFAULT NULL COMMENT '归属于集团Guid',
  `Codes` varchar(20) NOT NULL COMMENT '公司编号',
  `Layer` int(11) NOT NULL DEFAULT '0' COMMENT '层级',
  `Name` varchar(50) NOT NULL COMMENT '公司名称',
  `Logo` varchar(100) DEFAULT NULL COMMENT '公司Logo',
  `Corporate` varchar(50) DEFAULT NULL COMMENT '公司法人',
  `FoundTIme` datetime DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '创建日期',
  `Summary` varchar(2000) DEFAULT NULL COMMENT '公司文化',
  `Tel` varchar(50) DEFAULT NULL COMMENT '公司总机电话',
  `Fax` varchar(50) DEFAULT NULL COMMENT '传真',
  `Address` varchar(255) DEFAULT NULL COMMENT '公司地址',
  `DelStatus` bit(1) NOT NULL DEFAULT b'0' COMMENT '删除状态',
  `AddTime` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '添加时间',
  `EditTIme` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '修改时间',
  PRIMARY KEY (`Guid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of syscompany
-- ----------------------------
INSERT INTO `syscompany` VALUES ('59dd330c-13a5-4ef8-9e86-918e95b5b1e2', null, '1001', '0', '北京美亚集团', null, '张三', '2010-05-30 00:00:00', null, '010-57178368', '57178368', '北京朝阳区', '\0', '2018-03-29 14:03:59', '2018-03-29 14:03:59');

-- ----------------------------
-- Table structure for sysdepartment
-- ----------------------------
DROP TABLE IF EXISTS `sysdepartment`;
CREATE TABLE `sysdepartment` (
  `Guid` varchar(50) NOT NULL COMMENT '唯一标识',
  `Codes` varchar(50) NOT NULL COMMENT '部门编号',
  `ParentGuid` varchar(50) DEFAULT NULL COMMENT '上级部门',
  `ParentGuidList` varchar(1000) DEFAULT NULL COMMENT '多个上级部门的集合',
  `CompanyGuid` varchar(50) NOT NULL COMMENT '所属公司Guid',
  `Layer` int(11) NOT NULL DEFAULT '0' COMMENT '部门层级',
  `Name` varchar(50) NOT NULL COMMENT '部门名称',
  `Summary` varchar(500) DEFAULT NULL COMMENT '部门备注',
  `Address` varchar(100) DEFAULT NULL COMMENT '部门办公地址',
  `DepartmentTel` varchar(50) DEFAULT NULL COMMENT '部门电话',
  `Sort` int(11) NOT NULL DEFAULT '0' COMMENT '排序字段',
  `DelStatus` bit(1) NOT NULL DEFAULT b'0' COMMENT '删除状态',
  `AddTime` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '添加部门',
  `EditTime` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '修改时间',
  PRIMARY KEY (`Guid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of sysdepartment
-- ----------------------------
INSERT INTO `sysdepartment` VALUES ('e9b04253-49a3-47bc-82e2-53d506fda641', '1001', '', null, '59dd330c-13a5-4ef8-9e86-918e95b5b1e2', '0', '技术部', null, null, '010-88888888', '0', '\0', '2018-03-29 14:06:48', '2018-03-29 14:06:48');

-- ----------------------------
-- Table structure for sysimage
-- ----------------------------
DROP TABLE IF EXISTS `sysimage`;
CREATE TABLE `sysimage` (
  `Guid` varchar(50) NOT NULL,
  `TheGuid` varchar(50) DEFAULT NULL COMMENT '所属栏目Guid',
  `Types` int(11) NOT NULL DEFAULT '0' COMMENT '图片类型，一个栏目可有多个图片类型',
  `Title` varchar(50) DEFAULT NULL COMMENT '图片名称',
  `ImgBig` varchar(255) NOT NULL COMMENT '图片原图',
  `ImgSmall` varchar(255) DEFAULT NULL COMMENT '图片缩略图',
  `IsCover` bit(1) NOT NULL DEFAULT b'0' COMMENT '是否为封面',
  `Sort` int(11) NOT NULL DEFAULT '0' COMMENT '排序字段',
  PRIMARY KEY (`Guid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of sysimage
-- ----------------------------

-- ----------------------------
-- Table structure for syslog
-- ----------------------------
DROP TABLE IF EXISTS `syslog`;
CREATE TABLE `syslog` (
  `Guid` varchar(50) NOT NULL COMMENT '唯一标识——Guid',
  `UserGuid` varchar(50) NOT NULL COMMENT '日志操作ID',
  `DepartGuid` varchar(50) DEFAULT NULL COMMENT '日志操作人所属部门Guid',
  `CompanyGuid` varchar(50) DEFAULT NULL COMMENT '日志操作人所属公司Guid',
  `OptionTable` varchar(50) DEFAULT NULL COMMENT '操作表名',
  `Summary` varchar(255) NOT NULL COMMENT '日志操作内容',
  `IP` varchar(20) NOT NULL COMMENT '日志操作IP地址',
  `MacUrl` varchar(50) DEFAULT NULL COMMENT '日志操作Mac地址',
  `LogType` int(11) NOT NULL DEFAULT '0' COMMENT '日志操作类型',
  `Urls` varchar(255) NOT NULL COMMENT '日志操作Url',
  `AddTIme` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '日志添加时间',
  PRIMARY KEY (`Guid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of syslog
-- ----------------------------

-- ----------------------------
-- Table structure for sysmenu
-- ----------------------------
DROP TABLE IF EXISTS `sysmenu`;
CREATE TABLE `sysmenu` (
  `Guid` varchar(50) NOT NULL COMMENT '唯一标识Guid',
  `SiteGuid` varchar(50) DEFAULT NULL COMMENT '所属站点或公司菜单',
  `ParentGuid` varchar(50) DEFAULT NULL COMMENT '菜单父级Guid',
  `Name` varchar(50) NOT NULL COMMENT '菜单名称',
  `NameCode` varchar(50) NOT NULL COMMENT '菜单名称标识',
  `ParentGuidList` varchar(500) DEFAULT NULL COMMENT '所属父级的集合',
  `Layer` int(10) NOT NULL COMMENT '菜单深度',
  `Urls` varchar(255) DEFAULT NULL COMMENT '菜单Url',
  `Controller` varchar(50) DEFAULT NULL COMMENT '菜单控制器名称',
  `Action` varchar(50) DEFAULT NULL COMMENT '菜单方法名称',
  `Icon` varchar(50) DEFAULT NULL COMMENT '菜单图标Class',
  `Sort` int(11) NOT NULL DEFAULT '0' COMMENT '菜单排序',
  `Status` bit(1) NOT NULL DEFAULT b'1' COMMENT '菜单状态 true=正常 false=不显示',
  `EditTime` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '修改时间',
  `AddTIme` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '添加时间',
  PRIMARY KEY (`Guid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of sysmenu
-- ----------------------------

-- ----------------------------
-- Table structure for syspermissions
-- ----------------------------
DROP TABLE IF EXISTS `syspermissions`;
CREATE TABLE `syspermissions` (
  `RoleGuid` varchar(50) NOT NULL COMMENT '角色Guid',
  `AuthorizeGuid` varchar(50) NOT NULL COMMENT '认证的标识【CURD】'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of syspermissions
-- ----------------------------

-- ----------------------------
-- Table structure for sysperson
-- ----------------------------
DROP TABLE IF EXISTS `sysperson`;
CREATE TABLE `sysperson` (
  `Guid` varchar(50) NOT NULL COMMENT '唯一标识',
  `RoleGuid` varchar(50) NOT NULL COMMENT '角色Guid',
  `DepartmentGuid` varchar(50) DEFAULT NULL COMMENT '部门Guid',
  `CompayGuid` varchar(50) DEFAULT NULL COMMENT '公司Guid',
  `LoginName` varchar(50) NOT NULL COMMENT '登录账号',
  `LoginPwd` varchar(255) NOT NULL COMMENT '登录密码',
  `TrueName` varchar(50) NOT NULL COMMENT '真是姓名',
  `Codes` varchar(50) NOT NULL COMMENT '员工编号',
  `HeadPic` varchar(255) NOT NULL COMMENT '头像',
  `Sex` varchar(10) NOT NULL COMMENT '性别',
  `Mobile` varchar(20) DEFAULT NULL COMMENT '手机号码',
  `Email` varchar(200) DEFAULT NULL COMMENT '邮箱地址',
  `QQ` varchar(20) DEFAULT NULL COMMENT 'QQ号码',
  `WebXin` varchar(50) DEFAULT NULL COMMENT '微信号码',
  `WorkTel` varchar(50) DEFAULT NULL COMMENT '办公室电话',
  `LoginStatus` bit(1) NOT NULL DEFAULT b'1' COMMENT '状态 0=冻结1=正常',
  `DelStatus` bit(1) NOT NULL DEFAULT b'0' COMMENT '删除状态',
  `PostStatus` bit(1) NOT NULL DEFAULT b'1' COMMENT '在职状态  0=离职1=在职',
  `AuditStatus` bit(1) NOT NULL COMMENT '审核状态',
  `Birthday` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '生日',
  `IDCard` varchar(50) DEFAULT NULL COMMENT '身份证号码',
  `IDCardImg` varchar(255) DEFAULT NULL COMMENT '身份证图片',
  `NativePlaceCity` varchar(100) DEFAULT NULL COMMENT '籍贯',
  `AccountCity` varchar(100) DEFAULT NULL COMMENT '户口所在地',
  `LiveCity` varchar(100) DEFAULT NULL COMMENT '居住地址',
  `PoliticalStatus` varchar(50) DEFAULT NULL COMMENT '政治面貌',
  `Ethnic` varchar(50) DEFAULT NULL COMMENT '民族',
  `Faith` varchar(50) DEFAULT NULL COMMENT '信仰',
  `Marriage` varchar(50) DEFAULT NULL COMMENT '婚姻',
  `Education` varchar(50) DEFAULT NULL COMMENT '学历',
  `Hobbies` varchar(2000) DEFAULT NULL COMMENT '个人爱好',
  `LanguageSkills` varchar(255) DEFAULT NULL COMMENT '语言能力',
  `Specialty` varchar(2000) DEFAULT NULL COMMENT '特长',
  `LastLoginTime` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '最后登录时间',
  `LoginSum` int(11) NOT NULL DEFAULT '0' COMMENT '登录次数',
  `IosToken` varchar(100) DEFAULT NULL COMMENT '苹果设备的唯一标识',
  `AndRoidToken` varchar(100) DEFAULT NULL COMMENT '安卓设备的唯一标识',
  `IsPush` bit(1) NOT NULL DEFAULT b'1' COMMENT '是否允许推送通知',
  `DeviceName` varchar(50) DEFAULT NULL COMMENT '设备名称',
  `AddTime` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '添加时间',
  `EditTime` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '修改时间',
  PRIMARY KEY (`Guid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of sysperson
-- ----------------------------
INSERT INTO `sysperson` VALUES ('25008bc0-3032-4a73-a6cc-79758d71313a', '2949c266-575a-4e5d-a663-e39d5f33df7e', 'e9b04253-49a3-47bc-82e2-53d506fda641', '59dd330c-13a5-4ef8-9e86-918e95b5b1e2', 'admins', '123456', '张三', '1001', '/themes/img/add-photo.svg', '男', '13888888888', '5665464654@qq.com', '5665464654', '5665464654', null, '', '\0', '', '', '2018-03-29 19:06:25', '5646987464646464', null, '北京市/北京市/石景山区', '北京市/北京市/房山区', '北京市/北京市/昌平区', '民进会员', '汉族', '科学信仰', '保密', '大专', null, '法语', null, '2018-03-29 19:19:51', '0', null, null, '', null, '2018-03-29 19:19:51', '2018-03-29 19:19:52');
INSERT INTO `sysperson` VALUES ('c8f2478a-0493-4334-ace1-437713f263cb', '2949c266-575a-4e5d-a663-e39d5f33df7e', 'e9b04253-49a3-47bc-82e2-53d506fda641', '59dd330c-13a5-4ef8-9e86-918e95b5b1e2', 'admins', 'B/H6l6yNwEs=', '李四', '1002', '/themes/img/headpic/4a796573-bad8-42e9-be81-7f9a4f577e16.jpg', '男', '13666666666', '564446466@qq.com', '656546464645', '564446466', '010-86545664', '', '\0', '', '', '2018-03-29 17:16:10', null, null, '北京市/北京市/丰台区', '河北省/沧州市/东光县', '贵州省/贵阳市/云岩区', '民进会员', '汉族', '社会观信仰', '未婚', '硕士', '1111112222222222222', '汉语,英语,日语', 'aaaaaaaaaaaaaaabbbbbbbb\ncccc\nddddd', '2018-03-30 07:44:18', '0', null, null, '', null, '2018-03-30 07:44:18', '2018-03-30 07:44:19');

-- ----------------------------
-- Table structure for syspersoncontact
-- ----------------------------
DROP TABLE IF EXISTS `syspersoncontact`;
CREATE TABLE `syspersoncontact` (
  `Guid` varchar(50) NOT NULL COMMENT '唯一标识',
  `PersonGuid` varchar(50) NOT NULL COMMENT '员工Guid',
  `Name` varchar(50) NOT NULL COMMENT '联系人姓名',
  `Relation` varchar(50) NOT NULL COMMENT '联系人关系',
  `Mobile` varchar(50) NOT NULL COMMENT '联系方式',
  `Address` varchar(100) DEFAULT NULL COMMENT '联系地址',
  `IsUrgent` bit(1) NOT NULL DEFAULT b'0' COMMENT '是否为紧急联系人',
  `AddTime` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '添加时间',
  `EditTime` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '修改时间',
  PRIMARY KEY (`Guid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of syspersoncontact
-- ----------------------------
INSERT INTO `syspersoncontact` VALUES ('5d372c6e-c1b0-44e6-83d7-accc29c21fc3', 'c8f2478a-0493-4334-ace1-437713f263cb', '张三', '同学', '13666666666', null, '', '2018-03-30 13:41:33', '2018-03-30 13:41:34');

-- ----------------------------
-- Table structure for syspersoneducate
-- ----------------------------
DROP TABLE IF EXISTS `syspersoneducate`;
CREATE TABLE `syspersoneducate` (
  `Guid` varchar(50) NOT NULL COMMENT '唯一标识',
  `PersonGuid` varchar(50) NOT NULL COMMENT '员工Gudi',
  `EducateType` varchar(10) NOT NULL COMMENT '类型如国立，私立，职业培训',
  `AdmissionTime` datetime NOT NULL COMMENT '入学时间',
  `GraduateTime` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '毕业时间',
  `SchoolName` varchar(50) NOT NULL COMMENT '院校名称',
  `Specialty` varchar(50) DEFAULT NULL COMMENT '专业',
  PRIMARY KEY (`Guid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of syspersoneducate
-- ----------------------------
INSERT INTO `syspersoneducate` VALUES ('d4d727c9-32c6-49fd-baf8-a085086f4b88', 'c8f2478a-0493-4334-ace1-437713f263cb', '国立', '2010-02-10 00:00:00', '0001-01-01 00:00:00', '测试有欢笑', '政治学');

-- ----------------------------
-- Table structure for syspersonwork
-- ----------------------------
DROP TABLE IF EXISTS `syspersonwork`;
CREATE TABLE `syspersonwork` (
  `Guid` varchar(50) NOT NULL COMMENT '唯一标识',
  `PersonGuid` varchar(50) NOT NULL COMMENT '员工Guid',
  `EntryTime` varchar(50) DEFAULT NULL COMMENT '入职时间',
  `OutTime` varchar(50) DEFAULT NULL COMMENT '离职时间',
  `Address` varchar(255) DEFAULT NULL COMMENT '在职地点',
  `CompanyName` varchar(50) DEFAULT NULL COMMENT '公司名称',
  `PostName` varchar(50) DEFAULT NULL COMMENT '职务',
  `WorkContent` varchar(500) DEFAULT NULL COMMENT '工作内容',
  `Witness` varchar(30) DEFAULT NULL COMMENT '证明人',
  `WitnessTel` varchar(50) DEFAULT NULL COMMENT '证明人联系方式',
  `OutSummary` varchar(500) DEFAULT NULL COMMENT '离职原因',
  `SalarySummary` varchar(500) DEFAULT NULL COMMENT '薪资描述',
  PRIMARY KEY (`Guid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of syspersonwork
-- ----------------------------
INSERT INTO `syspersonwork` VALUES ('578bf9ab-fdf1-4486-8e9c-0b9c640e2942', 'c8f2478a-0493-4334-ace1-437713f263cb', 'sfsfsf', 'sdfsd', 'sfdsfd', 'afasdfas', 'asdf', 'sdfdsf', 'dsfsf', 'sfdsfd', 'sfdsfdsfdsf', null);

-- ----------------------------
-- Table structure for sysrole
-- ----------------------------
DROP TABLE IF EXISTS `sysrole`;
CREATE TABLE `sysrole` (
  `Guid` varchar(50) NOT NULL,
  `DepartmentGuid` varchar(50) NOT NULL COMMENT '部门Guid',
  `Name` varchar(50) NOT NULL COMMENT '部门名称',
  `Codes` varchar(50) NOT NULL COMMENT '部门编号',
  `IsSystem` bit(1) NOT NULL DEFAULT b'0' COMMENT '是否为超级管理员',
  `Summary` varchar(500) DEFAULT NULL COMMENT '部门描述',
  `AddTime` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '添加时间',
  `EditTime` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '修改时间',
  PRIMARY KEY (`Guid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of sysrole
-- ----------------------------
INSERT INTO `sysrole` VALUES ('2949c266-575a-4e5d-a663-e39d5f33df7e', 'e9b04253-49a3-47bc-82e2-53d506fda641', '超级管理员', '1001', '', '超级管理员', '2018-03-29 14:12:08', '2018-03-29 14:12:08');

-- ----------------------------
-- Table structure for sysrolemenu
-- ----------------------------
DROP TABLE IF EXISTS `sysrolemenu`;
CREATE TABLE `sysrolemenu` (
  `RoleGuid` varchar(50) NOT NULL COMMENT '角色Guid',
  `MenuGuid` varchar(50) NOT NULL COMMENT '菜单Guid',
  PRIMARY KEY (`RoleGuid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of sysrolemenu
-- ----------------------------
